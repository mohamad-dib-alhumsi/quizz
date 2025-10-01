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

        // Hoofdquiz timer
        private int _timeLeft = 60;
        private bool _skipUsed = false;

        // Vraag-timer
        private Timer questionTimer;
        private int _questionTimeLeft = 5;

        public FormQuiz(User user, int categoryId = -1)
        {
            InitializeComponent();
            _loggedUser = user;
            selectedCategoryId = categoryId;

            // Vraag-timer instellen
            questionTimer = new Timer();
            questionTimer.Interval = 1000;
            questionTimer.Tick += QuestionTimer_Tick;

            // Vragen laden
            LoadQuestions(selectedCategoryId, null);

            if (_quizQuestions.Count == 0)
            {
                MessageBox.Show("Geen vragen gevonden voor deze categorie!");
                this.DialogResult = DialogResult.Cancel;
                this.Close();
                return;
            }

            ShowQuestion();
            StartMainTimer();
        }

        private void LoadQuestions(int? categoryId = null, int? desiredCount = null)
        {
            _quizQuestions = new List<Question>();

            string sql = @"SELECT {0} QuestionId, Text, TimeLimitSeconds 
                           FROM Questions 
                           WHERE (@cat IS NULL OR CategoryId = @cat) 
                           ORDER BY NEWID()";

            string topClause = desiredCount.HasValue ? $"TOP ({desiredCount.Value})" : "";
            sql = string.Format(sql, topClause);

            var paramList = new List<SqlParameter>
            {
                new SqlParameter("@cat", categoryId.HasValue && categoryId.Value > 0
                                       ? (object)categoryId.Value
                                       : DBNull.Value)
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

            // Reset vraag-timer
            _questionTimeLeft = 5;
            lblQuestionTimer.Text = $"Vraag tijd: {_questionTimeLeft}s";
            questionTimer.Start();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            questionTimer.Stop();

            if ((bool)clicked.Tag)
                _score++;
            else
                _score--;

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

        private void StartMainTimer()
        {
            quizTimer.Interval = 1000;
            quizTimer.Tick += QuizTimer_Tick;
            quizTimer.Start();
        }

        // 🔥 Alleen deze 2 event-handlers houden
        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            _timeLeft--;
            lblTimer.Text = $"Tijd: {_timeLeft}s";

            if (_timeLeft > 10)
                lblTimer.ForeColor = System.Drawing.Color.Green;
            else
                lblTimer.ForeColor = System.Drawing.Color.Red;

            if (_timeLeft <= 0)
            {
                quizTimer.Stop();
                EndQuiz();
            }
        }

        private void QuestionTimer_Tick(object sender, EventArgs e)
        {
            _questionTimeLeft--;
            lblQuestionTimer.Text = $"Vraag tijd: {_questionTimeLeft}s";

            if (_questionTimeLeft <= 0)
            {
                questionTimer.Stop();
                currentQuestionIndex++;
                ShowQuestion();
            }
        }

        private void btnEndQuiz_Click(object sender, EventArgs e)
        {
            quizTimer.Stop();
            questionTimer.Stop();
            EndQuiz();
        }

        private void EndQuiz()
        {
            int questionsCount = _quizQuestions.Count;
            int durationSeconds = 60 - _timeLeft;

            var sql = @"INSERT INTO Games (UserId, CategoryId, Score, DurationSeconds, QuestionsCount) 
                        VALUES (@u, @c, @s, @d, @qc);
                        SELECT SCOPE_IDENTITY();";

            var categoryParam = (selectedCategoryId <= 0)
                ? (object)DBNull.Value
                : selectedCategoryId;

            var gameId = Db.ExecuteScalar(sql,
                new SqlParameter("@u", _loggedUser.UserId),
                new SqlParameter("@c", categoryParam),
                new SqlParameter("@s", _score),
                new SqlParameter("@d", durationSeconds),
                new SqlParameter("@qc", questionsCount)
            );

            var dt = Db.ExecuteSelect(@"
                SELECT TOP 10 u.Username, MAX(g.Score) AS Score, MIN(g.StartedAt) AS StartedAt
                FROM Games g
                JOIN Users u ON u.UserId = g.UserId
                GROUP BY u.Username
                ORDER BY Score DESC, StartedAt ASC
            ");
            dgvScoreboard.DataSource = dt;

            int place = -1;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (Convert.ToString(dt.Rows[i]["Username"]) == _loggedUser.Username)
                {
                    place = i + 1;
                    break;
                }
            }

            string message = place != -1
                ? $"Gefeliciteerd! Je staat op plaats {place} in de top 10.\nJe eindscore is {_score}.\n\nWil je opnieuw spelen of uitloggen?"
                : $"Je eindscore is {_score}.\n\nWil je opnieuw spelen?";

            var result = MessageBox.Show(message, "Quiz Resultaat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Retry;
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void FormQuiz_Load(object sender, EventArgs e)
        {
            lblTimer.Text = $"Tijd: {_timeLeft}s";
            lblScore.Text = "Score: 0";
            lblQuestionTimer.Text = $"Vraag tijd: {_questionTimeLeft}s";
        }
    }
}
