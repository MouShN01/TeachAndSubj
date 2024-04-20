namespace TeachAndSubj
{
    partial class EditTeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.teachNameLabel = new System.Windows.Forms.Label();
            this.subjChkBox = new System.Windows.Forms.CheckedListBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teachNameLabel
            // 
            this.teachNameLabel.AutoSize = true;
            this.teachNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teachNameLabel.Location = new System.Drawing.Point(184, 9);
            this.teachNameLabel.Name = "teachNameLabel";
            this.teachNameLabel.Size = new System.Drawing.Size(79, 29);
            this.teachNameLabel.TabIndex = 0;
            this.teachNameLabel.Text = "label1";
            // 
            // subjChkBox
            // 
            this.subjChkBox.FormattingEnabled = true;
            this.subjChkBox.Location = new System.Drawing.Point(59, 50);
            this.subjChkBox.Name = "subjChkBox";
            this.subjChkBox.Size = new System.Drawing.Size(329, 140);
            this.subjChkBox.TabIndex = 1;
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBtn.Location = new System.Drawing.Point(159, 205);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(118, 40);
            this.changeBtn.TabIndex = 2;
            this.changeBtn.Text = "Змінити";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // EditTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 264);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.subjChkBox);
            this.Controls.Add(this.teachNameLabel);
            this.Name = "EditTeacherForm";
            this.Text = "EditTeacherForm";
            this.Load += new System.EventHandler(this.EditTeacherForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label teachNameLabel;
        private System.Windows.Forms.CheckedListBox subjChkBox;
        private System.Windows.Forms.Button changeBtn;
    }
}