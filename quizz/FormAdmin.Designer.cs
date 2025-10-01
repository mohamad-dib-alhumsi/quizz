namespace quizz
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpUsers;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnDeleteUser;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.grpQuestion = new System.Windows.Forms.GroupBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.grpAnswers = new System.Windows.Forms.GroupBox();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.chkCorrect1 = new System.Windows.Forms.CheckBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.chkCorrect2 = new System.Windows.Forms.CheckBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.chkCorrect3 = new System.Windows.Forms.CheckBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.chkCorrect4 = new System.Windows.Forms.CheckBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.grpUsers = new System.Windows.Forms.GroupBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUpdateQuestion = new System.Windows.Forms.Button();
            this.btnDeleteQuestion = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpCategory.SuspendLayout();
            this.grpQuestion.SuspendLayout();
            this.grpAnswers.SuspendLayout();
            this.grpUsers.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpCategory
            // 
            this.grpCategory.BackColor = System.Drawing.Color.White;
            this.grpCategory.Controls.Add(this.lblCategory);
            this.grpCategory.Controls.Add(this.cmbCategory);
            this.grpCategory.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCategory.ForeColor = System.Drawing.Color.FromArgb(0, 74, 173);
            this.grpCategory.Location = new System.Drawing.Point(18, 24);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(520, 70);
            this.grpCategory.TabIndex = 0;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "📁 Categorie";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(15, 30);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Categorie:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(110, 27);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(380, 28);
            this.cmbCategory.TabIndex = 1;
            cmbCategory.SelectedIndexChanged += (s, ev) => LoadQuestions();            // 
            // grpQuestion
            // 
            this.grpQuestion.BackColor = System.Drawing.Color.White;
            this.grpQuestion.Controls.Add(this.lblQuestion);
            this.grpQuestion.Controls.Add(this.txtQuestion);
            this.grpQuestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpQuestion.ForeColor = System.Drawing.Color.FromArgb(0, 74, 173);
            this.grpQuestion.Location = new System.Drawing.Point(18, 100);
            this.grpQuestion.Name = "grpQuestion";
            this.grpQuestion.Size = new System.Drawing.Size(520, 80);
            this.grpQuestion.TabIndex = 1;
            this.grpQuestion.TabStop = false;
            this.grpQuestion.Text = "❓ Vraag";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblQuestion.ForeColor = System.Drawing.Color.Black;
            this.lblQuestion.Location = new System.Drawing.Point(15, 35);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(50, 20);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Vraag:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtQuestion.Location = new System.Drawing.Point(110, 35);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(380, 27);
            this.txtQuestion.TabIndex = 1;
            // 
            // grpAnswers
            // 
            this.grpAnswers.BackColor = System.Drawing.Color.White;
            this.grpAnswers.Controls.Add(this.txtAnswer1);
            this.grpAnswers.Controls.Add(this.chkCorrect1);
            this.grpAnswers.Controls.Add(this.txtAnswer2);
            this.grpAnswers.Controls.Add(this.chkCorrect2);
            this.grpAnswers.Controls.Add(this.txtAnswer3);
            this.grpAnswers.Controls.Add(this.chkCorrect3);
            this.grpAnswers.Controls.Add(this.txtAnswer4);
            this.grpAnswers.Controls.Add(this.chkCorrect4);
            this.grpAnswers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpAnswers.ForeColor = System.Drawing.Color.FromArgb(0, 74, 173);
            this.grpAnswers.Location = new System.Drawing.Point(18, 190);
            this.grpAnswers.Name = "grpAnswers";
            this.grpAnswers.Size = new System.Drawing.Size(520, 190);
            this.grpAnswers.TabIndex = 2;
            this.grpAnswers.TabStop = false;
            this.grpAnswers.Text = "📝 Antwoorden";
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnswer1.Location = new System.Drawing.Point(20, 35);
            this.txtAnswer1.Name = "txtAnswer1";
            this.txtAnswer1.Size = new System.Drawing.Size(350, 27);
            this.txtAnswer1.TabIndex = 0;
            // 
            // chkCorrect1
            // 
            this.chkCorrect1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCorrect1.Location = new System.Drawing.Point(390, 35);
            this.chkCorrect1.Name = "chkCorrect1";
            this.chkCorrect1.Size = new System.Drawing.Size(100, 27);
            this.chkCorrect1.TabIndex = 1;
            this.chkCorrect1.Text = "Correct";
            this.chkCorrect1.UseVisualStyleBackColor = true;
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnswer2.Location = new System.Drawing.Point(20, 70);
            this.txtAnswer2.Name = "txtAnswer2";
            this.txtAnswer2.Size = new System.Drawing.Size(350, 27);
            this.txtAnswer2.TabIndex = 2;
            // 
            // chkCorrect2
            // 
            this.chkCorrect2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCorrect2.Location = new System.Drawing.Point(390, 70);
            this.chkCorrect2.Name = "chkCorrect2";
            this.chkCorrect2.Size = new System.Drawing.Size(100, 27);
            this.chkCorrect2.TabIndex = 3;
            this.chkCorrect2.Text = "Correct";
            this.chkCorrect2.UseVisualStyleBackColor = true;
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnswer3.Location = new System.Drawing.Point(20, 107);
            this.txtAnswer3.Name = "txtAnswer3";
            this.txtAnswer3.Size = new System.Drawing.Size(350, 27);
            this.txtAnswer3.TabIndex = 4;
            // 
            // chkCorrect3
            // 
            this.chkCorrect3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCorrect3.Location = new System.Drawing.Point(390, 105);
            this.chkCorrect3.Name = "chkCorrect3";
            this.chkCorrect3.Size = new System.Drawing.Size(100, 27);
            this.chkCorrect3.TabIndex = 5;
            this.chkCorrect3.Text = "Correct";
            this.chkCorrect3.UseVisualStyleBackColor = true;
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAnswer4.Location = new System.Drawing.Point(20, 140);
            this.txtAnswer4.Name = "txtAnswer4";
            this.txtAnswer4.Size = new System.Drawing.Size(350, 27);
            this.txtAnswer4.TabIndex = 6;
            // 
            // chkCorrect4
            // 
            this.chkCorrect4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkCorrect4.Location = new System.Drawing.Point(390, 140);
            this.chkCorrect4.Name = "chkCorrect4";
            this.chkCorrect4.Size = new System.Drawing.Size(100, 27);
            this.chkCorrect4.TabIndex = 7;
            this.chkCorrect4.Text = "Correct";
            this.chkCorrect4.UseVisualStyleBackColor = true;
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.BackColor = System.Drawing.Color.FromArgb(0, 74, 173);
            this.btnAddQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddQuestion.ForeColor = System.Drawing.Color.White;
            this.btnAddQuestion.Location = new System.Drawing.Point(18, 390);
            this.btnAddQuestion.Name = "btnAddQuestion";
            this.btnAddQuestion.Size = new System.Drawing.Size(170, 40);
            this.btnAddQuestion.TabIndex = 3;
            this.btnAddQuestion.Text = "➕ Toevoegen";
            this.btnAddQuestion.UseVisualStyleBackColor = false;
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // grpUsers
            // 
            this.grpUsers.BackColor = System.Drawing.Color.White;
            this.grpUsers.Controls.Add(this.txtUsername);
            this.grpUsers.Controls.Add(this.chkIsAdmin);
            this.grpUsers.Controls.Add(this.btnAddUser);
            this.grpUsers.Controls.Add(this.btnUpdateUser);
            this.grpUsers.Controls.Add(this.btnDeleteUser);
            this.grpUsers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpUsers.ForeColor = System.Drawing.Color.FromArgb(0, 74, 173);
            this.grpUsers.Location = new System.Drawing.Point(6, 6);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(420, 180);
            this.grpUsers.TabIndex = 4;
            this.grpUsers.TabStop = false;
            this.grpUsers.Text = "👥 Gebruikersbeheer";
            this.grpUsers.Enter += new System.EventHandler(this.grpUsers_Enter);
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.Location = new System.Drawing.Point(20, 30);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(250, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.chkIsAdmin.Location = new System.Drawing.Point(276, 29);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(104, 24);
            this.chkIsAdmin.TabIndex = 1;
            this.chkIsAdmin.Text = "Admin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(0, 74, 173);
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAddUser.ForeColor = System.Drawing.Color.White;
            this.btnAddUser.Location = new System.Drawing.Point(20, 80);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(120, 40);
            this.btnAddUser.TabIndex = 2;
            this.btnAddUser.Text = "➕ Toevoegen";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Location = new System.Drawing.Point(150, 80);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(120, 40);
            this.btnUpdateUser.TabIndex = 3;
            this.btnUpdateUser.Text = "✏️ Bewerken";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDeleteUser.ForeColor = System.Drawing.Color.White;
            this.btnDeleteUser.Location = new System.Drawing.Point(280, 80);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(120, 40);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "🗑️ Verwijderen";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1151, 700);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(240, 245, 249);
            this.tabPage1.Controls.Add(this.btnDeleteQuestion);
            this.tabPage1.Controls.Add(this.btnUpdateQuestion);
            this.tabPage1.Controls.Add(this.grpAnswers);
            this.tabPage1.Controls.Add(this.btnAddQuestion);
            this.tabPage1.Controls.Add(this.grpQuestion);
            this.tabPage1.Controls.Add(this.grpCategory);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1143, 671);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "❓ Vragenbeheer";
            // 
            // btnUpdateQuestion
            // 
            this.btnUpdateQuestion.BackColor = System.Drawing.Color.FromArgb(255, 193, 7);
            this.btnUpdateQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateQuestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdateQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateQuestion.Location = new System.Drawing.Point(194, 390);
            this.btnUpdateQuestion.Name = "btnUpdateQuestion";
            this.btnUpdateQuestion.Size = new System.Drawing.Size(170, 40);
            this.btnUpdateQuestion.TabIndex = 4;
            this.btnUpdateQuestion.Text = "✏️ Bewerken";
            this.btnUpdateQuestion.UseVisualStyleBackColor = false;
            this.btnUpdateQuestion.Click += new System.EventHandler(this.btnUpdateQuestion_Click);
            // 
            // btnDeleteQuestion
            // 
            this.btnDeleteQuestion.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnDeleteQuestion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteQuestion.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDeleteQuestion.ForeColor = System.Drawing.Color.White;
            this.btnDeleteQuestion.Location = new System.Drawing.Point(370, 390);
            this.btnDeleteQuestion.Name = "btnDeleteQuestion";
            this.btnDeleteQuestion.Size = new System.Drawing.Size(170, 40);
            this.btnDeleteQuestion.TabIndex = 5;
            this.btnDeleteQuestion.Text = "🗑️ Verwijderen";
            this.btnDeleteQuestion.UseVisualStyleBackColor = false;
            this.btnDeleteQuestion.Click += new System.EventHandler(this.btnDeleteQuestion_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(240, 245, 249);
            this.tabPage2.Controls.Add(this.grpUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1143, 671);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "👥 Gebruikersbeheer";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1175, 724);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Dashboard - Quizz Applicatie";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            this.grpQuestion.ResumeLayout(false);
            this.grpQuestion.PerformLayout();
            this.grpAnswers.ResumeLayout(false);
            this.grpAnswers.PerformLayout();
            this.grpUsers.ResumeLayout(false);
            this.grpUsers.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.GroupBox grpQuestion;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.GroupBox grpAnswers;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.CheckBox chkCorrect1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.CheckBox chkCorrect2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.CheckBox chkCorrect3;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.CheckBox chkCorrect4;
        private System.Windows.Forms.Button btnAddQuestion;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUpdateQuestion;
        private System.Windows.Forms.Button btnDeleteQuestion;
    }
}