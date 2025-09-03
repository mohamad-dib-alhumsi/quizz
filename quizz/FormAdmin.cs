using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using quizz.Data;
using quizz.Models;

namespace quizz
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            LoadCategories();
        }

        private void LoadCategories()
        {
            var dt = Db.ExecuteSelect("SELECT CategoryId, Name FROM Categories");
            cmbCategory.DisplayMember = "Name";
            cmbCategory.ValueMember = "CategoryId";
            cmbCategory.DataSource = dt;
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            // Check vraag
            if (string.IsNullOrWhiteSpace(txtQuestion.Text))
            {
                MessageBox.Show("Voer een vraag in!");
                return;
            }

            // Check categorie
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Selecteer een categorie!");
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

            // Insert question + answers in transaction
            using (var conn = new SqlConnection(Db.ConnectionString))
            {
                conn.Open();
                using (var tran = conn.BeginTransaction())
                {
                    try
                    {
                        // Voeg vraag toe
                        int qid;
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

                        // Voeg antwoorden toe
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

                        // Feedback + clear
                        MessageBox.Show("Vraag toegevoegd!");
                        txtQuestion.Clear();
                        txtAnswer1.Clear();
                        txtAnswer2.Clear();
                        txtAnswer3.Clear();
                        txtAnswer4.Clear();
                        chkCorrect1.Checked = chkCorrect2.Checked = chkCorrect3.Checked = chkCorrect4.Checked = false;
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show("Er ging iets mis bij het toevoegen van de vraag:\n" + ex.Message);
                    }
                }
            }
        }
    }
}
