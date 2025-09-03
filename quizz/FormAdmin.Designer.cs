namespace quizz
{
    partial class FormAdmin
    {
        private System.ComponentModel.IContainer components = null;

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
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.txtAnswer1 = new System.Windows.Forms.TextBox();
            this.txtAnswer2 = new System.Windows.Forms.TextBox();
            this.txtAnswer3 = new System.Windows.Forms.TextBox();
            this.txtAnswer4 = new System.Windows.Forms.TextBox();
            this.chkCorrect1 = new System.Windows.Forms.CheckBox();
            this.chkCorrect2 = new System.Windows.Forms.CheckBox();
            this.chkCorrect3 = new System.Windows.Forms.CheckBox();
            this.chkCorrect4 = new System.Windows.Forms.CheckBox();
            this.btnAddQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCategory
            // 
            this.lblCategory.Location = new System.Drawing.Point(20, 20);
            this.lblCategory.Size = new System.Drawing.Size(100, 20);
            this.lblCategory.Text = "Categorie:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Location = new System.Drawing.Point(130, 20);
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            // 
            // lblQuestion
            // 
            this.lblQuestion.Location = new System.Drawing.Point(20, 60);
            this.lblQuestion.Size = new System.Drawing.Size(100, 20);
            this.lblQuestion.Text = "Vraag:";
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(130, 60);
            this.txtQuestion.Size = new System.Drawing.Size(400, 23);
            // 
            // lblAnswers
            // 
            this.lblAnswers.Location = new System.Drawing.Point(20, 100);
            this.lblAnswers.Size = new System.Drawing.Size(100, 20);
            this.lblAnswers.Text = "Antwoorden:";
            // 
            // txtAnswer1
            // 
            this.txtAnswer1.Location = new System.Drawing.Point(130, 100);
            this.txtAnswer1.Size = new System.Drawing.Size(200, 23);
            // 
            // txtAnswer2
            // 
            this.txtAnswer2.Location = new System.Drawing.Point(130, 140);
            this.txtAnswer2.Size = new System.Drawing.Size(200, 23);
            // 
            // txtAnswer3
            // 
            this.txtAnswer3.Location = new System.Drawing.Point(130, 180);
            this.txtAnswer3.Size = new System.Drawing.Size(200, 23);
            // 
            // txtAnswer4
            // 
            this.txtAnswer4.Location = new System.Drawing.Point(130, 220);
            this.txtAnswer4.Size = new System.Drawing.Size(200, 23);
            // 
            // checkboxes
            this.chkCorrect1.Location = new System.Drawing.Point(340, 100);
            this.chkCorrect1.Text = "Correct";
            this.chkCorrect2.Location = new System.Drawing.Point(340, 140);
            this.chkCorrect2.Text = "Correct";
            this.chkCorrect3.Location = new System.Drawing.Point(340, 180);
            this.chkCorrect3.Text = "Correct";
            this.chkCorrect4.Location = new System.Drawing.Point(340, 220);
            this.chkCorrect4.Text = "Correct";
            // 
            // btnAddQuestion
            // 
            this.btnAddQuestion.Location = new System.Drawing.Point(130, 260);
            this.btnAddQuestion.Size = new System.Drawing.Size(150, 30);
            this.btnAddQuestion.Text = "Vraag toevoegen";
            this.btnAddQuestion.Click += new System.EventHandler(this.btnAddQuestion_Click);
            // 
            // FormAdmin
            // 
            this.ClientSize = new System.Drawing.Size(600, 320);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.lblAnswers);
            this.Controls.Add(this.txtAnswer1);
            this.Controls.Add(this.txtAnswer2);
            this.Controls.Add(this.txtAnswer3);
            this.Controls.Add(this.txtAnswer4);
            this.Controls.Add(this.chkCorrect1);
            this.Controls.Add(this.chkCorrect2);
            this.Controls.Add(this.chkCorrect3);
            this.Controls.Add(this.chkCorrect4);
            this.Controls.Add(this.btnAddQuestion);
            this.Text = "Admin - Vragen beheren";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.TextBox txtAnswer1;
        private System.Windows.Forms.TextBox txtAnswer2;
        private System.Windows.Forms.TextBox txtAnswer3;
        private System.Windows.Forms.TextBox txtAnswer4;
        private System.Windows.Forms.CheckBox chkCorrect1;
        private System.Windows.Forms.CheckBox chkCorrect2;
        private System.Windows.Forms.CheckBox chkCorrect3;
        private System.Windows.Forms.CheckBox chkCorrect4;
        private System.Windows.Forms.Button btnAddQuestion;
    }
}
