namespace quizz
{
    partial class FormQuiz
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnAnswer1;
        private System.Windows.Forms.Button btnAnswer2;
        private System.Windows.Forms.Button btnAnswer3;
        private System.Windows.Forms.Button btnAnswer4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnEndQuiz;
        private System.Windows.Forms.DataGridView dgvScoreboard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnEndQuiz = new System.Windows.Forms.Button();
            this.dgvScoreboard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblQuestion.Location = new System.Drawing.Point(20, 37);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(500, 60);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Vraag komt hier...";
            // 
            // btnAnswer1
            // 
            this.btnAnswer1.Location = new System.Drawing.Point(20, 172);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(200, 40);
            this.btnAnswer1.TabIndex = 1;
            this.btnAnswer1.Text = "Antwoord 1";
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer2
            // 
            this.btnAnswer2.Location = new System.Drawing.Point(20, 232);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(200, 40);
            this.btnAnswer2.TabIndex = 2;
            this.btnAnswer2.Text = "Antwoord 2";
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer3
            // 
            this.btnAnswer3.Location = new System.Drawing.Point(20, 292);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(200, 40);
            this.btnAnswer3.TabIndex = 3;
            this.btnAnswer3.Text = "Antwoord 3";
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // btnAnswer4
            // 
            this.btnAnswer4.Location = new System.Drawing.Point(20, 352);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(200, 40);
            this.btnAnswer4.TabIndex = 4;
            this.btnAnswer4.Text = "Antwoord 4";
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer_Click);
            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(400, 20);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(120, 30);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score: 0";
            // 
            // btnEndQuiz
            // 
            this.btnEndQuiz.Location = new System.Drawing.Point(431, 172);
            this.btnEndQuiz.Name = "btnEndQuiz";
            this.btnEndQuiz.Size = new System.Drawing.Size(120, 40);
            this.btnEndQuiz.TabIndex = 6;
            this.btnEndQuiz.Text = "Quiz beëindigen";
            this.btnEndQuiz.Click += new System.EventHandler(this.btnEndQuiz_Click);
            // 
            // dgvScoreboard
            // 
            this.dgvScoreboard.ColumnHeadersHeight = 29;
            this.dgvScoreboard.Location = new System.Drawing.Point(20, 435);
            this.dgvScoreboard.Name = "dgvScoreboard";
            this.dgvScoreboard.RowHeadersWidth = 51;
            this.dgvScoreboard.Size = new System.Drawing.Size(500, 150);
            this.dgvScoreboard.TabIndex = 7;
            // 
            // FormQuiz
            // 
            this.ClientSize = new System.Drawing.Size(563, 597);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnAnswer1);
            this.Controls.Add(this.btnAnswer2);
            this.Controls.Add(this.btnAnswer3);
            this.Controls.Add(this.btnAnswer4);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnEndQuiz);
            this.Controls.Add(this.dgvScoreboard);
            this.Name = "FormQuiz";
            this.Text = "Quiz Spelen";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreboard)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
