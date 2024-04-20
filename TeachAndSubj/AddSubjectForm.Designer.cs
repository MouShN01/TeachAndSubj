namespace TeachAndSubj
{
    partial class AddSubjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.subjTextBox = new System.Windows.Forms.TextBox();
            this.teachCheckBox = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addSubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть назву предмету";
            // 
            // subjTextBox
            // 
            this.subjTextBox.Location = new System.Drawing.Point(12, 28);
            this.subjTextBox.Name = "subjTextBox";
            this.subjTextBox.Size = new System.Drawing.Size(353, 22);
            this.subjTextBox.TabIndex = 1;
            // 
            // teachCheckBox
            // 
            this.teachCheckBox.FormattingEnabled = true;
            this.teachCheckBox.Location = new System.Drawing.Point(12, 90);
            this.teachCheckBox.Name = "teachCheckBox";
            this.teachCheckBox.Size = new System.Drawing.Size(353, 225);
            this.teachCheckBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оберіть викладачів";
            // 
            // addSubject
            // 
            this.addSubject.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addSubject.Location = new System.Drawing.Point(147, 321);
            this.addSubject.Name = "addSubject";
            this.addSubject.Size = new System.Drawing.Size(75, 23);
            this.addSubject.TabIndex = 4;
            this.addSubject.Text = "Додати";
            this.addSubject.UseVisualStyleBackColor = true;
            this.addSubject.Click += new System.EventHandler(this.addSubject_Click);
            // 
            // AddSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 357);
            this.Controls.Add(this.addSubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teachCheckBox);
            this.Controls.Add(this.subjTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddSubjectForm";
            this.Text = "AddSubjectForm";
            this.Load += new System.EventHandler(this.AddSubjectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox subjTextBox;
        private System.Windows.Forms.CheckedListBox teachCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addSubject;
    }
}