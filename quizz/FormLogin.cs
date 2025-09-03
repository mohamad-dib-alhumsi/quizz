using quizz.Data;
using quizz.Helpers;
using quizz.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quizz
{
    public partial class FormLogin : Form
    {
        private User _loggedUser;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMessage.Text = "Vul alles in";
                return;
            }

            var exists = Db.ExecuteScalar("SELECT COUNT(1) FROM Users WHERE Username = @u",
                new SqlParameter("@u", username));
            if (Convert.ToInt32(exists) > 0)
            {
                lblMessage.Text = "Username bestaat al";
                return;
            }

            PasswordHelper.CreateHash(password, out byte[] salt, out byte[] hash);
            Db.ExecuteNonQuery(
                "INSERT INTO Users (Username, PasswordHash, PasswordSalt) VALUES (@u, @h, @s)",
                new SqlParameter("@u", username),
                new SqlParameter("@h", hash),
                new SqlParameter("@s", salt)
            );

            lblMessage.Text = "Account aangemaakt!";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text;
            var dt = Db.ExecuteSelect(
                "SELECT UserId, Username, PasswordHash, PasswordSalt, IsAdmin FROM Users WHERE Username = @u",
                new SqlParameter("@u", username)
            );

            if (dt.Rows.Count == 0)
            {
                lblMessage.Text = "Geen gebruiker";
                return;
            }

            var row = dt.Rows[0];
            var salt = (byte[])row["PasswordSalt"];
            var hash = (byte[])row["PasswordHash"];
            if (!PasswordHelper.VerifyPassword(password, salt, hash))
            {
                lblMessage.Text = "Wachtwoord fout";
                return;
            }

            _loggedUser = new User
            {
                UserId = (int)row["UserId"],
                Username = row["Username"].ToString(),
                IsAdmin = (bool)row["IsAdmin"]
            };

            lblMessage.Text = $"Welkom, {_loggedUser.Username}";

            var quizForm = new FormQuiz(_loggedUser);
            quizForm.Show();
            this.Hide();
        }
    }
}
