namespace quizz
{
    partial class FormLogin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // lblMessage
            this.lblMessage.Location = new System.Drawing.Point(20, 10);
            this.lblMessage.Size = new System.Drawing.Size(300, 20);

            // txtUsername
            this.txtUsername.Location = new System.Drawing.Point(20, 40);
            this.txtUsername.Size = new System.Drawing.Size(200, 23);

            // txtPassword
            this.txtPassword.Location = new System.Drawing.Point(20, 70);
            this.txtPassword.Size = new System.Drawing.Size(200, 23);
            this.txtPassword.PasswordChar = '*';

            // btnLogin
            this.btnLogin.Location = new System.Drawing.Point(20, 100);
            this.btnLogin.Size = new System.Drawing.Size(90, 30);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            // btnRegister
            this.btnRegister.Location = new System.Drawing.Point(130, 100);
            this.btnRegister.Size = new System.Drawing.Size(90, 30);
            this.btnRegister.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // FormLogin
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
