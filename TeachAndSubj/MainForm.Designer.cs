namespace TeachAndSubj
{
    partial class MainForm
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
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.addTeachBtn = new System.Windows.Forms.Button();
            this.addSubj = new System.Windows.Forms.Button();
            this.dgvSubj = new System.Windows.Forms.DataGridView();
            this.showSubjBtn = new System.Windows.Forms.Button();
            this.showTeachBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.editTeachBtn = new System.Windows.Forms.Button();
            this.editSubjBtn = new System.Windows.Forms.Button();
            this.sortAlphBtn = new System.Windows.Forms.Button();
            this.sortsubjBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubj)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AllowUserToAddRows = false;
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(12, 12);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RowHeadersWidth = 51;
            this.dgvTeachers.RowTemplate.Height = 24;
            this.dgvTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTeachers.Size = new System.Drawing.Size(405, 321);
            this.dgvTeachers.TabIndex = 0;
            this.dgvTeachers.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvTeachers_UserDeletingRow);
            // 
            // addTeachBtn
            // 
            this.addTeachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTeachBtn.Location = new System.Drawing.Point(12, 339);
            this.addTeachBtn.Name = "addTeachBtn";
            this.addTeachBtn.Size = new System.Drawing.Size(192, 30);
            this.addTeachBtn.TabIndex = 1;
            this.addTeachBtn.Text = "Додати вчителя";
            this.addTeachBtn.UseVisualStyleBackColor = true;
            this.addTeachBtn.Click += new System.EventHandler(this.addTeachBtn_Click);
            // 
            // addSubj
            // 
            this.addSubj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSubj.Location = new System.Drawing.Point(757, 339);
            this.addSubj.Name = "addSubj";
            this.addSubj.Size = new System.Drawing.Size(205, 30);
            this.addSubj.TabIndex = 3;
            this.addSubj.Text = "Додати предмет";
            this.addSubj.UseVisualStyleBackColor = true;
            this.addSubj.Click += new System.EventHandler(this.addSubj_Click);
            // 
            // dgvSubj
            // 
            this.dgvSubj.AllowUserToAddRows = false;
            this.dgvSubj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubj.Location = new System.Drawing.Point(645, 12);
            this.dgvSubj.Name = "dgvSubj";
            this.dgvSubj.RowHeadersWidth = 51;
            this.dgvSubj.RowTemplate.Height = 24;
            this.dgvSubj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubj.Size = new System.Drawing.Size(405, 321);
            this.dgvSubj.TabIndex = 2;
            this.dgvSubj.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgvSubj_UserDeletingRow);
            // 
            // showSubjBtn
            // 
            this.showSubjBtn.Location = new System.Drawing.Point(496, 133);
            this.showSubjBtn.Name = "showSubjBtn";
            this.showSubjBtn.Size = new System.Drawing.Size(75, 23);
            this.showSubjBtn.TabIndex = 4;
            this.showSubjBtn.Text = "--->";
            this.showSubjBtn.UseVisualStyleBackColor = true;
            this.showSubjBtn.Click += new System.EventHandler(this.showSubjBtn_Click);
            // 
            // showTeachBtn
            // 
            this.showTeachBtn.Location = new System.Drawing.Point(496, 204);
            this.showTeachBtn.Name = "showTeachBtn";
            this.showTeachBtn.Size = new System.Drawing.Size(75, 23);
            this.showTeachBtn.TabIndex = 5;
            this.showTeachBtn.Text = "<---";
            this.showTeachBtn.UseVisualStyleBackColor = true;
            this.showTeachBtn.Click += new System.EventHandler(this.showTeachBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refreshBtn.Location = new System.Drawing.Point(445, 356);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(171, 38);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Відобразити все";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // editTeachBtn
            // 
            this.editTeachBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editTeachBtn.Location = new System.Drawing.Point(12, 375);
            this.editTeachBtn.Name = "editTeachBtn";
            this.editTeachBtn.Size = new System.Drawing.Size(192, 30);
            this.editTeachBtn.TabIndex = 7;
            this.editTeachBtn.Text = "Змінити зв\'язки";
            this.editTeachBtn.UseVisualStyleBackColor = true;
            this.editTeachBtn.Click += new System.EventHandler(this.editTeachBtn_Click);
            // 
            // editSubjBtn
            // 
            this.editSubjBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editSubjBtn.Location = new System.Drawing.Point(757, 375);
            this.editSubjBtn.Name = "editSubjBtn";
            this.editSubjBtn.Size = new System.Drawing.Size(205, 30);
            this.editSubjBtn.TabIndex = 8;
            this.editSubjBtn.Text = "Змінити зв\'язки";
            this.editSubjBtn.UseVisualStyleBackColor = true;
            this.editSubjBtn.Click += new System.EventHandler(this.editSubjBtn_Click);
            // 
            // sortAlphBtn
            // 
            this.sortAlphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortAlphBtn.Location = new System.Drawing.Point(210, 339);
            this.sortAlphBtn.Name = "sortAlphBtn";
            this.sortAlphBtn.Size = new System.Drawing.Size(207, 30);
            this.sortAlphBtn.TabIndex = 9;
            this.sortAlphBtn.Text = "Сортувати за алфавітом";
            this.sortAlphBtn.UseVisualStyleBackColor = true;
            this.sortAlphBtn.Click += new System.EventHandler(this.sortAlphBtn_Click);
            // 
            // sortsubjBtn
            // 
            this.sortsubjBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortsubjBtn.Location = new System.Drawing.Point(210, 375);
            this.sortsubjBtn.Name = "sortsubjBtn";
            this.sortsubjBtn.Size = new System.Drawing.Size(207, 30);
            this.sortsubjBtn.TabIndex = 10;
            this.sortsubjBtn.Text = "Сортувати за предметами";
            this.sortsubjBtn.UseVisualStyleBackColor = true;
            this.sortsubjBtn.Click += new System.EventHandler(this.sortsubjBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 416);
            this.Controls.Add(this.sortsubjBtn);
            this.Controls.Add(this.sortAlphBtn);
            this.Controls.Add(this.editSubjBtn);
            this.Controls.Add(this.editTeachBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.showTeachBtn);
            this.Controls.Add(this.showSubjBtn);
            this.Controls.Add(this.addSubj);
            this.Controls.Add(this.dgvSubj);
            this.Controls.Add(this.addTeachBtn);
            this.Controls.Add(this.dgvTeachers);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubj)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Button addTeachBtn;
        private System.Windows.Forms.Button addSubj;
        private System.Windows.Forms.DataGridView dgvSubj;
        private System.Windows.Forms.Button showSubjBtn;
        private System.Windows.Forms.Button showTeachBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button editTeachBtn;
        private System.Windows.Forms.Button editSubjBtn;
        private System.Windows.Forms.Button sortAlphBtn;
        private System.Windows.Forms.Button sortsubjBtn;
    }
}