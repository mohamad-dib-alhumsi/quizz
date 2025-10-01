namespace quizz.Forms
{
    partial class FormQuizSetup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.lblChooseCategory = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.panelHeader.Controls.Add(this.lblSubtitle);
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 100);
            this.panelHeader.TabIndex = 3;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblSubtitle.Location = new System.Drawing.Point(32, 60);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(316, 23);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Configureer je quiz en begin met spelen";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(30, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(172, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Quiz Setup";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(74)))), ((int)(((byte)(173)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(30, 250);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(440, 45);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "START QUIZ";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCategories.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(30, 148);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(440, 31);
            this.cmbCategories.TabIndex = 1;
            this.cmbCategories.DropDown += new System.EventHandler(this.cmbCategories_DropDown);
            // 
            // lblChooseCategory
            // 
            this.lblChooseCategory.AutoSize = true;
            this.lblChooseCategory.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblChooseCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblChooseCategory.Location = new System.Drawing.Point(50, 92);
            this.lblChooseCategory.Name = "lblChooseCategory";
            this.lblChooseCategory.Size = new System.Drawing.Size(177, 25);
            this.lblChooseCategory.TabIndex = 0;
            this.lblChooseCategory.Text = "Kies een categorie:";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lblChooseCategory);
            this.panelMain.Controls.Add(this.cmbCategories);
            this.panelMain.Controls.Add(this.btnStart);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 100);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(30);
            this.panelMain.Size = new System.Drawing.Size(500, 350);
            this.panelMain.TabIndex = 4;
            // 
            // FormQuizSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(246)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuizSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Setup";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        // Event handlers
        private void btnStart_MouseEnter(object sender, System.EventArgs e)
        {
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(0, 60, 140);
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnStart_MouseLeave(object sender, System.EventArgs e)
        {
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(0, 74, 173);
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
        }

        private void cmbCategories_DropDown(object sender, System.EventArgs e)
        {
            this.cmbCategories.BackColor = System.Drawing.Color.FromArgb(240, 245, 255);
        }

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Label lblChooseCategory;
        private System.Windows.Forms.Panel panelMain;
    }
}
