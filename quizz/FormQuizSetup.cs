using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using quizz.Data;
using quizz.Models;

namespace quizz.Forms
{
    public partial class FormQuizSetup : Form
    {
        private User _loggedUser;

        public FormQuizSetup(User user)
        {
            InitializeComponent();
            _loggedUser = user;
            LoadCategories();
        }

        private void LoadCategories()
        {
            var dt = Db.ExecuteSelect("SELECT CategoryId, Name FROM Categories");
            cmbCategories.DisplayMember = "Name";
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.DataSource = dt;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbCategories.SelectedValue == null)
            {
                MessageBox.Show("Kies een categorie!");
                return;
            }

            int categoryId = Convert.ToInt32(cmbCategories.SelectedValue);
            using (var quizForm = new FormQuiz(_loggedUser, categoryId))
            {
                this.Hide();
                quizForm.ShowDialog(); // Quiz modal openen
                this.DialogResult = DialogResult.OK; // hiermee sluiten we setup na quiz
            }
        }

    }
}
