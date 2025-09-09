namespace quizz.Forms
{
    partial class FormQuizSetup
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblChooseCategory;
        private System.Windows.Forms.ComboBox cmbCategories;
        private System.Windows.Forms.Button btnStart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblChooseCategory = new System.Windows.Forms.Label();
            this.cmbCategories = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblChooseCategory
            // 
            this.lblChooseCategory.AutoSize = true;
            this.lblChooseCategory.Location = new System.Drawing.Point(30, 30);
            this.lblChooseCategory.Name = "lblChooseCategory";
            this.lblChooseCategory.Size = new System.Drawing.Size(123, 15);
            this.lblChooseCategory.TabIndex = 0;
            this.lblChooseCategory.Text = "Kies een categorie:";
            // 
            // cmbCategories
            // 
            this.cmbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategories.FormattingEnabled = true;
            this.cmbCategories.Location = new System.Drawing.Point(30, 60);
            this.cmbCategories.Name = "cmbCategories";
            this.cmbCategories.Size = new System.Drawing.Size(220, 23);
            this.cmbCategories.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(30, 100);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(220, 35);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Quiz";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // FormQuizSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 160);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbCategories);
            this.Controls.Add(this.lblChooseCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormQuizSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz Setup";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
