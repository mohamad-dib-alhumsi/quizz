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
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Timer quizTimer;
        private System.Windows.Forms.Label lblQuestionTimer;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Panel panelAnswers;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();

            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnAnswer1 = new System.Windows.Forms.Button();
            this.btnAnswer2 = new System.Windows.Forms.Button();
            this.btnAnswer3 = new System.Windows.Forms.Button();
            this.btnAnswer4 = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnEndQuiz = new System.Windows.Forms.Button();
            this.dgvScoreboard = new System.Windows.Forms.DataGridView();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnSkip = new System.Windows.Forms.Button();
            this.quizTimer = new System.Windows.Forms.Timer(this.components);
            this.lblQuestionTimer = new System.Windows.Forms.Label();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.panelAnswers = new System.Windows.Forms.Panel();
            this.panelControls = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreboard)).BeginInit();
            this.panelQuestion.SuspendLayout();
            this.panelAnswers.SuspendLayout();
            this.panelControls.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Controls.Add(this.lblScore);
            this.panelHeader.Controls.Add(this.lblTimer);
            this.panelHeader.Controls.Add(this.lblQuestionTimer);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(784, 60);
            this.panelHeader.TabIndex = 10;

            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(134, 30);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Quiz Spelen";

            // lblTimer
            // 
            this.lblTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTimer.ForeColor = System.Drawing.Color.White;
            this.lblTimer.Location = new System.Drawing.Point(500, 20);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(120, 20);
            this.lblTimer.TabIndex = 0;
            this.lblTimer.Text = "Totale Tijd: 60s";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblQuestionTimer
            // 
            this.lblQuestionTimer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestionTimer.ForeColor = System.Drawing.Color.White;
            this.lblQuestionTimer.Location = new System.Drawing.Point(350, 20);
            this.lblQuestionTimer.Name = "lblQuestionTimer";
            this.lblQuestionTimer.Size = new System.Drawing.Size(120, 20);
            this.lblQuestionTimer.TabIndex = 10;
            this.lblQuestionTimer.Text = "Vraag Tijd: 5s";
            this.lblQuestionTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(630, 15);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(140, 30);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "Score: 0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // panelQuestion
            // 
            this.panelQuestion.BackColor = System.Drawing.Color.White;
            this.panelQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelQuestion.Controls.Add(this.lblQuestion);
            this.panelQuestion.Location = new System.Drawing.Point(20, 80);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(744, 120);
            this.panelQuestion.TabIndex = 11;

            // lblQuestion
            // 
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQuestion.Location = new System.Drawing.Point(0, 0);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Padding = new System.Windows.Forms.Padding(20);
            this.lblQuestion.Size = new System.Drawing.Size(742, 118);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Vraag komt hier...";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelAnswers
            // 
            this.panelAnswers.Controls.Add(this.btnAnswer1);
            this.panelAnswers.Controls.Add(this.btnAnswer2);
            this.panelAnswers.Controls.Add(this.btnAnswer3);
            this.panelAnswers.Controls.Add(this.btnAnswer4);
            this.panelAnswers.Location = new System.Drawing.Point(20, 220);
            this.panelAnswers.Name = "panelAnswers";
            this.panelAnswers.Size = new System.Drawing.Size(500, 280);
            this.panelAnswers.TabIndex = 12;

            // btnAnswer1
            // 
            this.btnAnswer1.BackColor = System.Drawing.Color.White;
            this.btnAnswer1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnswer1.Location = new System.Drawing.Point(0, 20);
            this.btnAnswer1.Name = "btnAnswer1";
            this.btnAnswer1.Size = new System.Drawing.Size(500, 50);
            this.btnAnswer1.TabIndex = 2;
            this.btnAnswer1.Text = "Antwoord 1";
            this.btnAnswer1.UseVisualStyleBackColor = false;
            this.btnAnswer1.Click += new System.EventHandler(this.btnAnswer_Click);
            this.btnAnswer1.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.btnAnswer1.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);

            // btnAnswer2
            // 
            this.btnAnswer2.BackColor = System.Drawing.Color.White;
            this.btnAnswer2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnswer2.Location = new System.Drawing.Point(0, 80);
            this.btnAnswer2.Name = "btnAnswer2";
            this.btnAnswer2.Size = new System.Drawing.Size(500, 50);
            this.btnAnswer2.TabIndex = 3;
            this.btnAnswer2.Text = "Antwoord 2";
            this.btnAnswer2.UseVisualStyleBackColor = false;
            this.btnAnswer2.Click += new System.EventHandler(this.btnAnswer_Click);
            this.btnAnswer2.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.btnAnswer2.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);

            // btnAnswer3
            // 
            this.btnAnswer3.BackColor = System.Drawing.Color.White;
            this.btnAnswer3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnswer3.Location = new System.Drawing.Point(0, 140);
            this.btnAnswer3.Name = "btnAnswer3";
            this.btnAnswer3.Size = new System.Drawing.Size(500, 50);
            this.btnAnswer3.TabIndex = 4;
            this.btnAnswer3.Text = "Antwoord 3";
            this.btnAnswer3.UseVisualStyleBackColor = false;
            this.btnAnswer3.Click += new System.EventHandler(this.btnAnswer_Click);
            this.btnAnswer3.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.btnAnswer3.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);

            // btnAnswer4
            // 
            this.btnAnswer4.BackColor = System.Drawing.Color.White;
            this.btnAnswer4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswer4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAnswer4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnswer4.Location = new System.Drawing.Point(0, 200);
            this.btnAnswer4.Name = "btnAnswer4";
            this.btnAnswer4.Size = new System.Drawing.Size(500, 50);
            this.btnAnswer4.TabIndex = 5;
            this.btnAnswer4.Text = "Antwoord 4";
            this.btnAnswer4.UseVisualStyleBackColor = false;
            this.btnAnswer4.Click += new System.EventHandler(this.btnAnswer_Click);
            this.btnAnswer4.MouseEnter += new System.EventHandler(this.btnAnswer_MouseEnter);
            this.btnAnswer4.MouseLeave += new System.EventHandler(this.btnAnswer_MouseLeave);

            // panelControls
            // 
            this.panelControls.Controls.Add(this.btnSkip);
            this.panelControls.Controls.Add(this.btnEndQuiz);
            this.panelControls.Location = new System.Drawing.Point(540, 220);
            this.panelControls.Name = "panelControls";
            this.panelControls.Size = new System.Drawing.Size(224, 120);
            this.panelControls.TabIndex = 13;

            // btnSkip
            // 
            this.btnSkip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnSkip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSkip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSkip.ForeColor = System.Drawing.Color.White;
            this.btnSkip.Location = new System.Drawing.Point(20, 70);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(184, 40);
            this.btnSkip.TabIndex = 8;
            this.btnSkip.Text = "Vraag Overslaan";
            this.btnSkip.UseVisualStyleBackColor = false;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            this.btnSkip.MouseEnter += new System.EventHandler(this.btnControl_MouseEnter);
            this.btnSkip.MouseLeave += new System.EventHandler(this.btnControl_MouseLeave);

            // btnEndQuiz
            // 
            this.btnEndQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEndQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndQuiz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEndQuiz.ForeColor = System.Drawing.Color.White;
            this.btnEndQuiz.Location = new System.Drawing.Point(20, 20);
            this.btnEndQuiz.Name = "btnEndQuiz";
            this.btnEndQuiz.Size = new System.Drawing.Size(184, 40);
            this.btnEndQuiz.TabIndex = 7;
            this.btnEndQuiz.Text = "Quiz Beeindigen";
            this.btnEndQuiz.UseVisualStyleBackColor = false;
            this.btnEndQuiz.Click += new System.EventHandler(this.btnEndQuiz_Click);
            this.btnEndQuiz.MouseEnter += new System.EventHandler(this.btnControl_MouseEnter);
            this.btnEndQuiz.MouseLeave += new System.EventHandler(this.btnControl_MouseLeave);

            // dgvScoreboard
            // 
            this.dgvScoreboard.AllowUserToAddRows = false;
            this.dgvScoreboard.AllowUserToDeleteRows = false;
            this.dgvScoreboard.AllowUserToResizeRows = false;
            this.dgvScoreboard.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScoreboard.BackgroundColor = System.Drawing.Color.White;
            this.dgvScoreboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvScoreboard.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvScoreboard.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreboard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvScoreboard.ColumnHeadersHeight = 40;
            this.dgvScoreboard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvScoreboard.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvScoreboard.EnableHeadersVisualStyles = false;
            this.dgvScoreboard.Location = new System.Drawing.Point(20, 520);
            this.dgvScoreboard.Name = "dgvScoreboard";
            this.dgvScoreboard.ReadOnly = true;
            this.dgvScoreboard.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvScoreboard.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvScoreboard.RowHeadersVisible = false;
            this.dgvScoreboard.RowHeadersWidth = 51;
            this.dgvScoreboard.RowTemplate.Height = 35;
            this.dgvScoreboard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvScoreboard.Size = new System.Drawing.Size(744, 200);
            this.dgvScoreboard.TabIndex = 9;

            // FormQuiz
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.panelControls);
            this.Controls.Add(this.panelAnswers);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.dgvScoreboard);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinimumSize = new System.Drawing.Size(800, 780);
            this.Name = "FormQuiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Spelen";
            this.Load += new System.EventHandler(this.FormQuiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvScoreboard)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelQuestion.ResumeLayout(false);
            this.panelAnswers.ResumeLayout(false);
            this.panelControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        // Event handlers voor hover effects
        private void btnAnswer_MouseEnter(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
        }

        private void btnAnswer_MouseLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            btn.BackColor = System.Drawing.Color.White;
            btn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
        }

        private void btnControl_MouseEnter(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn == btnEndQuiz)
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(35)))), ((int)(((byte)(51)))));
            else if (btn == btnSkip)
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(167)))), ((int)(((byte)(38)))));
        }

        private void btnControl_MouseLeave(object sender, System.EventArgs e)
        {
            System.Windows.Forms.Button btn = (System.Windows.Forms.Button)sender;
            if (btn == btnEndQuiz)
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            else if (btn == btnSkip)
                btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
        }
    }
}