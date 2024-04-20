namespace TeachAndSubj
{
    partial class EditSubjectForm
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
            this.subjNameLabel = new System.Windows.Forms.Label();
            this.teachChkbox = new System.Windows.Forms.CheckedListBox();
            this.changeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // subjNameLabel
            // 
            this.subjNameLabel.AutoSize = true;
            this.subjNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subjNameLabel.Location = new System.Drawing.Point(177, 9);
            this.subjNameLabel.Name = "subjNameLabel";
            this.subjNameLabel.Size = new System.Drawing.Size(79, 29);
            this.subjNameLabel.TabIndex = 0;
            this.subjNameLabel.Text = "label1";
            this.subjNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teachChkbox
            // 
            this.teachChkbox.FormattingEnabled = true;
            this.teachChkbox.Location = new System.Drawing.Point(54, 50);
            this.teachChkbox.Name = "teachChkbox";
            this.teachChkbox.Size = new System.Drawing.Size(328, 140);
            this.teachChkbox.TabIndex = 1;
            // 
            // changeBtn
            // 
            this.changeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeBtn.Location = new System.Drawing.Point(152, 205);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(120, 41);
            this.changeBtn.TabIndex = 2;
            this.changeBtn.Text = "Змінити";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // EditSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 270);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.teachChkbox);
            this.Controls.Add(this.subjNameLabel);
            this.Name = "EditSubjectForm";
            this.Text = "EditSubjectForm";
            this.Load += new System.EventHandler(this.EditSubjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label subjNameLabel;
        private System.Windows.Forms.CheckedListBox teachChkbox;
        private System.Windows.Forms.Button changeBtn;
    }
}