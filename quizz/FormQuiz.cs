using quizz.Data;
using quizz.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quizz
{
    public partial class FormQuiz : Form
    {
        private User _loggedUser;
        private int _score = 0;
        private int currentQuestionIndex = 0;
        private List<Question> _quizQuestions;
        private int selectedCategoryId = -1;

        // Timer + skip
        private int _timeLeft = 60;
        private bool _skipUsed = false;

        public FormQuiz(User user, int categoryId = -1)
        {
            InitializeComponent();
            _loggedUser = user;
            selectedCategoryId = categoryId;

            LoadQuestions(selectedCategoryId);
            ShowQuestion();
            StartTimer();
        }

        private void LoadQuestions(int? categoryId = null, int desiredCount = 10)
        {
            _quizQuestions = new List<Question>();

            string sql = @"SELECT TOP (@n) QuestionId, Text, TimeLimitSeconds 
                           FROM Questions 
                           WHERE (@cat IS NULL OR CategoryId = @cat) 
                           ORDER BY NEWID()";

            var paramList = new List<SqlParameter>
            {
                new SqlParameter("@n", desiredCount),
                new SqlParameter("@cat", categoryId.HasValue ? (object)categoryId.Value : DBNull.Value)
            };

            var dtQuestions = Db.ExecuteSelect(sql, paramList.ToArray());

            foreach (System.Data.DataRow row in dtQuestions.Rows)
            {
                int qid = (int)row["QuestionId"];
                var question = new Question
                {
                    QuestionId = qid,
                    Text = (string)row["Text"],
                    TimeLimitSeconds = (int)row["TimeLimitSeconds"],
                    Answers = new List<Answer>()
                };

                var dtAnswers = Db.ExecuteSelect(
                    "SELECT AnswerId, Text, IsCorrect FROM Answers WHERE QuestionId = @qid",
                    new SqlParameter("@qid", qid));

                foreach (System.Data.DataRow ansRow in dtAnswers.Rows)
                {
                    question.Answers.Add(new Answer
                    {
                        AnswerId = (int)ansRow["AnswerId"],
                        Text = (string)ansRow["Text"],
                        IsCorrect = (bool)ansRow["IsCorrect"]
                    });
                }

                _quizQuestions.Add(question);
            }
        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex >= _quizQuestions.Count)
            {
                EndQuiz();
                return;
            }

            var q = _quizQuestions[currentQuestionIndex];
            lblQuestion.Text = q.Text;

            var shuffledAnswers = new List<Answer>(q.Answers);
            var rnd = new Random();
            shuffledAnswers.Sort((a, b) => rnd.Next(-1, 2));

            btnAnswer1.Text = shuffledAnswers[0].Text;
            btnAnswer2.Text = shuffledAnswers[1].Text;
            btnAnswer3.Text = shuffledAnswers[2].Text;
            btnAnswer4.Text = shuffledAnswers[3].Text;

            btnAnswer1.Tag = shuffledAnswers[0].IsCorrect;
            btnAnswer2.Tag = shuffledAnswers[1].IsCorrect;
            btnAnswer3.Tag = shuffledAnswers[2].IsCorrect;
            btnAnswer4.Tag = shuffledAnswers[3].IsCorrect;
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;

            if ((bool)clicked.Tag)
                _score++;

            lblScore.Text = $"Score: {_score}";

            currentQuestionIndex++;
            ShowQuestion();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            if (_skipUsed)
            {
                MessageBox.Show("Je mag maar 1 vraag skippen!");
                return;
            }

            _skipUsed = true;
            currentQuestionIndex++;
            ShowQuestion();
        }

        private void StartTimer()
        {
            quizTimer.Interval = 1000; // 1 seconde
            quizTimer.Tick += QuizTimer_Tick;
            quizTimer.Start();
        }


        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            lblTimer.Text = $"Tijd: {_timeLeft}s";

            if (_timeLeft <= 0)
            {
                quizTimer.Stop();
                EndQuiz();
            }
        }

        private void btnEndQuiz_Click(object sender, EventArgs e)
        {
            quizTimer.Stop();
            EndQuiz();
        }

        private void EndQuiz()
        {
            int questionsCount = _quizQuestions.Count;
            int durationSeconds = 60 - _timeLeft;

            var sql = @"INSERT INTO Games (UserId, CategoryId, Score, DurationSeconds, QuestionsCount) 
                        VALUES (@u, @c, @s, @d, @qc);
                        SELECT SCOPE_IDENTITY();";

            var gameId = Db.ExecuteScalar(sql,
                new SqlParameter("@u", _loggedUser.UserId),
                new SqlParameter("@c", selectedCategoryId == -1 ? (object)DBNull.Value : selectedCategoryId),
                new SqlParameter("@s", _score),
                new SqlParameter("@d", durationSeconds),
                new SqlParameter("@qc", questionsCount)
            );

            var dt = Db.ExecuteSelect(@"SELECT TOP 10 u.Username, g.Score, g.StartedAt
                                        FROM Games g
                                        JOIN Users u ON u.UserId = g.UserId
                                        ORDER BY g.Score DESC, g.StartedAt ASC");
            dgvScoreboard.DataSource = dt;

            int place = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToString(dt.Rows[i]["Username"]) == _loggedUser.Username &&
                    Convert.ToInt32(dt.Rows[i]["Score"]) == _score)
                {
                    place = i + 1;
                    break;
                }
            }

            string message = place != -1
                ? $"Gefeliciteerd! Je staat op plaats {place} in de top 10.\nJe eindscore is {_score}."
                : $"Je eindscore is {_score}.";

            MessageBox.Show(message, "Quiz Resultaat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            lblTimer.Text = $"Tijd: {_timeLeft}s";
            lblScore.Text = "Score: 0";
        }
    }
}
