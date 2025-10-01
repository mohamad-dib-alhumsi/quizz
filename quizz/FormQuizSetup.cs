using System;
using System.Data;
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

            // Fix voor MissingManifestResourceException
            this.Icon = null;

            _loggedUser = user;
            LoadCategories();
        }

        private void LoadCategories()
        {
            var dt = Db.ExecuteSelect("SELECT CategoryId, Name FROM Categories");

            // Extra optie: Alles
            DataRow row = dt.NewRow();
            row["CategoryId"] = 0;
            row["Name"] = "Alles";
            dt.Rows.InsertAt(row, 0);

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
                quizForm.ShowDialog();
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
