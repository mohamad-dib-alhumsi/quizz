using quizz.Data;
using quizz.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace quizz
{
    public partial class FormAdmin : Form
    {
        private User _loggedUser;
        private int? _selectedQuestionId = null;
        private int? _selectedUserId = null;
        private DataGridView dgvQuestions;
        private DataGridView dgvUsers;

        public FormAdmin(User user)
        {
            InitializeComponent();
            _loggedUser = user;
            InitializeCustomComponents();
            LoadCategories();
            LoadUsers();
            LoadQuestions();
        }

        private void InitializeCustomComponents()
        {
            // DataGridView voor vragen
            dgvQuestions = new DataGridView
            {
                Location = new Point(20, 450),
                Size = new Size(1100, 200),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                EnableHeadersVisualStyles = false,
                Font = new Font("Segoe UI", 9),
                GridColor = Color.FromArgb(224, 224, 224)
            };

            dgvQuestions.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 74, 173),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            dgvQuestions.RowHeadersVisible = false;
            dgvQuestions.SelectionChanged += dgvQuestions_SelectionChanged;
            this.tabPage1.Controls.Add(dgvQuestions);

            // DataGridView voor gebruikers
            dgvUsers = new DataGridView
            {
                Location = new Point(20, 200),
                Size = new Size(1100, 180),
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                ReadOnly = true,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.None,
                EnableHeadersVisualStyles = false,
                Font = new Font("Segoe UI", 9),
                GridColor = Color.FromArgb(224, 224, 224)
            };

            dgvUsers.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                BackColor = Color.FromArgb(0, 74, 173),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Alignment = DataGridViewContentAlignment.MiddleLeft
            };

            dgvUsers.RowHeadersVisible = false;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            this.tabPage2.Controls.Add(dgvUsers);
        }

        // 🔹 USERS LADEN
        private void LoadUsers()
        {
            try
            {
                var dt = Db.ExecuteSelect("SELECT UserId, Username, IsAdmin FROM Users");
                dgvUsers.DataSource = dt;

                if (dgvUsers.Columns.Count > 0)
                {
                    dgvUsers.Columns["UserId"].HeaderText = "ID";
                    dgvUsers.Columns["UserId"].Width = 50;
                    dgvUsers.Columns["Username"].HeaderText = "Gebruikersnaam";
                    dgvUsers.Columns["Username"].Width = 200;
                    dgvUsers.Columns["IsAdmin"].HeaderText = "Admin";
                    dgvUsers.Columns["IsAdmin"].Width = 80;
                }

                _selectedUserId = null;
                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij laden gebruikers: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            SaveUser(isNew: true);
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == null)
            {
                MessageBox.Show("Selecteer eerst een gebruiker!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveUser(isNew: false);
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (_selectedUserId == null)
            {
                MessageBox.Show("Selecteer eerst een gebruiker!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Weet je zeker dat je deze gebruiker wilt verwijderen?", "Bevestigen",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                Db.ExecuteNonQuery("DELETE FROM Users WHERE UserId = @id",
                    new SqlParameter("@id", _selectedUserId.Value));

                MessageBox.Show("Gebruiker verwijderd!", "Succes",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadUsers();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij verwijderen: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveUser(bool isNew)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Voer een gebruikersnaam in!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (isNew)
                {
                    Db.ExecuteNonQuery(
                    "INSERT INTO Users (Username, PasswordHash, PasswordSalt, IsAdmin) VALUES (@u, @p, @s, @a)",
                    new SqlParameter("@u", txtUsername.Text),
                    new SqlParameter("@p", Encoding.UTF8.GetBytes("1234")),
                    new SqlParameter("@s", Encoding.UTF8.GetBytes("nosalt")),
                    new SqlParameter("@a", chkIsAdmin.Checked)
                     );

                    MessageBox.Show("Gebruiker toegevoegd!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Db.ExecuteNonQuery("UPDATE Users SET Username=@u, IsAdmin=@a WHERE UserId=@id",
                        new SqlParameter("@u", txtUsername.Text),
                        new SqlParameter("@a", chkIsAdmin.Checked),
                        new SqlParameter("@id", _selectedUserId.Value));
                    MessageBox.Show("Gebruiker bijgewerkt!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LoadUsers();
                ClearUserFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij opslaan: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearUserFields()
        {
            txtUsername.Clear();
            chkIsAdmin.Checked = false;
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0) return;

            var row = dgvUsers.SelectedRows[0];
            _selectedUserId = Convert.ToInt32(row.Cells["UserId"].Value);

            var dtUser = Db.ExecuteSelect("SELECT Username, IsAdmin FROM Users WHERE UserId = @id",
                new SqlParameter("@id", _selectedUserId.Value));
            txtUsername.Text = dtUser.Rows[0]["Username"].ToString();
            chkIsAdmin.Checked = (bool)dtUser.Rows[0]["IsAdmin"];
        }

        private void LoadCategories()
        {
            try
            {
                var dt = Db.ExecuteSelect("SELECT CategoryId, Name FROM Categories");
                cmbCategory.DisplayMember = "Name";
                cmbCategory.ValueMember = "CategoryId";
                cmbCategory.DataSource = dt;

                // Voeg event handler toe voor categorie wijziging
                cmbCategory.SelectedIndexChanged += (s, ev) => LoadQuestions();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij laden categorieën: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadQuestions()
        {
            if (cmbCategory.SelectedValue == null) return;

            try
            {
                int catId = Convert.ToInt32(cmbCategory.SelectedValue);
                var dt = Db.ExecuteSelect("SELECT QuestionId, Text FROM Questions WHERE CategoryId = @c",
                    new SqlParameter("@c", catId));
                dgvQuestions.DataSource = dt;

                if (dgvQuestions.Columns.Count > 0)
                {
                    dgvQuestions.Columns["QuestionId"].HeaderText = "ID";
                    dgvQuestions.Columns["QuestionId"].Width = 50;
                    dgvQuestions.Columns["Text"].HeaderText = "Vraag";
                    dgvQuestions.Columns["Text"].Width = 800;
                }

                _selectedQuestionId = null;
                ClearQuestionFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij laden vragen: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvQuestions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count == 0) return;

            var row = dgvQuestions.SelectedRows[0];
            _selectedQuestionId = Convert.ToInt32(row.Cells["QuestionId"].Value);

            try
            {
                var dtQuestion = Db.ExecuteSelect("SELECT Text FROM Questions WHERE QuestionId = @q",
                    new SqlParameter("@q", _selectedQuestionId.Value));
                txtQuestion.Text = dtQuestion.Rows[0]["Text"].ToString();

                var dtAnswers = Db.ExecuteSelect("SELECT AnswerId, Text, IsCorrect FROM Answers WHERE QuestionId = @q",
                    new SqlParameter("@q", _selectedQuestionId.Value));

                txtAnswer1.Text = dtAnswers.Rows[0]["Text"].ToString();
                chkCorrect1.Checked = (bool)dtAnswers.Rows[0]["IsCorrect"];
                txtAnswer2.Text = dtAnswers.Rows[1]["Text"].ToString();
                chkCorrect2.Checked = (bool)dtAnswers.Rows[1]["IsCorrect"];
                txtAnswer3.Text = dtAnswers.Rows[2]["Text"].ToString();
                chkCorrect3.Checked = (bool)dtAnswers.Rows[2]["IsCorrect"];
                txtAnswer4.Text = dtAnswers.Rows[3]["Text"].ToString();
                chkCorrect4.Checked = (bool)dtAnswers.Rows[3]["IsCorrect"];
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij laden vraag details: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            SaveQuestion(isNew: true);
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            if (_selectedQuestionId == null)
            {
                MessageBox.Show("Selecteer eerst een vraag!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SaveQuestion(isNew: false);
        }

        private void btnDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (_selectedQuestionId == null)
            {
                MessageBox.Show("Selecteer eerst een vraag om te verwijderen!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Weet je zeker dat je deze vraag wilt verwijderen?", "Bevestigen",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            try
            {
                using (var conn = new SqlConnection(Db.ConnectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            using (var cmd = conn.CreateCommand())
                            {
                                cmd.Transaction = tran;
                                cmd.CommandText = "DELETE FROM Answers WHERE QuestionId = @q";
                                cmd.Parameters.AddWithValue("@q", _selectedQuestionId.Value);
                                cmd.ExecuteNonQuery();
                            }

                            using (var cmd = conn.CreateCommand())
                            {
                                cmd.Transaction = tran;
                                cmd.CommandText = "DELETE FROM Questions WHERE QuestionId = @q";
                                cmd.Parameters.AddWithValue("@q", _selectedQuestionId.Value);
                                cmd.ExecuteNonQuery();
                            }

                            tran.Commit();
                            MessageBox.Show("Vraag verwijderd!", "Succes",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadQuestions();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij verwijderen: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveQuestion(bool isNew)
        {
            if (string.IsNullOrWhiteSpace(txtQuestion.Text))
            {
                MessageBox.Show("Voer een vraag in!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Selecteer een categorie!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valideer antwoorden
            if (string.IsNullOrWhiteSpace(txtAnswer1.Text) || string.IsNullOrWhiteSpace(txtAnswer2.Text) ||
                string.IsNullOrWhiteSpace(txtAnswer3.Text) || string.IsNullOrWhiteSpace(txtAnswer4.Text))
            {
                MessageBox.Show("Vul alle antwoorden in!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Valideer dat precies één antwoord correct is
            var correctAnswers = new List<bool> { chkCorrect1.Checked, chkCorrect2.Checked, chkCorrect3.Checked, chkCorrect4.Checked };
            if (correctAnswers.FindAll(x => x).Count != 1)
            {
                MessageBox.Show("Precies één antwoord moet correct zijn!", "Waarschuwing",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int catId = Convert.ToInt32(cmbCategory.SelectedValue);
            var answers = new List<Answer>
            {
                new Answer { Text = txtAnswer1.Text, IsCorrect = chkCorrect1.Checked },
                new Answer { Text = txtAnswer2.Text, IsCorrect = chkCorrect2.Checked },
                new Answer { Text = txtAnswer3.Text, IsCorrect = chkCorrect3.Checked },
                new Answer { Text = txtAnswer4.Text, IsCorrect = chkCorrect4.Checked }
            };

            try
            {
                using (var conn = new SqlConnection(Db.ConnectionString))
                {
                    conn.Open();
                    using (var tran = conn.BeginTransaction())
                    {
                        try
                        {
                            int qid;
                            if (isNew)
                            {
                                using (var cmd = conn.CreateCommand())
                                {
                                    cmd.Transaction = tran;
                                    cmd.CommandText = @"INSERT INTO Questions (CategoryId, Text, TimeLimitSeconds)
                                                        OUTPUT INSERTED.QuestionId
                                                        VALUES (@c, @t, @tl)";
                                    cmd.Parameters.AddWithValue("@c", catId);
                                    cmd.Parameters.AddWithValue("@t", txtQuestion.Text);
                                    cmd.Parameters.AddWithValue("@tl", 15);
                                    qid = (int)cmd.ExecuteScalar();
                                }
                            }
                            else
                            {
                                qid = _selectedQuestionId.Value;
                                using (var cmd = conn.CreateCommand())
                                {
                                    cmd.Transaction = tran;
                                    cmd.CommandText = "UPDATE Questions SET Text = @t, CategoryId = @c WHERE QuestionId = @q";
                                    cmd.Parameters.AddWithValue("@t", txtQuestion.Text);
                                    cmd.Parameters.AddWithValue("@c", catId);
                                    cmd.Parameters.AddWithValue("@q", qid);
                                    cmd.ExecuteNonQuery();
                                }

                                using (var cmd = conn.CreateCommand())
                                {
                                    cmd.Transaction = tran;
                                    cmd.CommandText = "DELETE FROM Answers WHERE QuestionId = @q";
                                    cmd.Parameters.AddWithValue("@q", qid);
                                    cmd.ExecuteNonQuery();
                                }
                            }

                            foreach (var ans in answers)
                            {
                                using (var cmd2 = conn.CreateCommand())
                                {
                                    cmd2.Transaction = tran;
                                    cmd2.CommandText = @"INSERT INTO Answers (QuestionId, Text, IsCorrect)
                                                         VALUES (@qid, @txt, @isC)";
                                    cmd2.Parameters.AddWithValue("@qid", qid);
                                    cmd2.Parameters.AddWithValue("@txt", ans.Text);
                                    cmd2.Parameters.AddWithValue("@isC", ans.IsCorrect);
                                    cmd2.ExecuteNonQuery();
                                }
                            }

                            tran.Commit();
                            MessageBox.Show(isNew ? "Vraag toegevoegd!" : "Vraag bijgewerkt!", "Succes",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadQuestions();
                            ClearQuestionFields();
                        }
                        catch (Exception ex)
                        {
                            tran.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Fout bij opslaan: {ex.Message}", "Fout",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearQuestionFields()
        {
            txtQuestion.Clear();
            txtAnswer1.Clear();
            txtAnswer2.Clear();
            txtAnswer3.Clear();
            txtAnswer4.Clear();
            chkCorrect1.Checked = chkCorrect2.Checked = chkCorrect3.Checked = chkCorrect4.Checked = false;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // Extra styling bij laden
            this.Refresh();
        }

        private void grpUsers_Enter(object sender, EventArgs e)
        {
            // Optioneel: extra styling wanneer groep geselecteerd wordt
        }
    }
}