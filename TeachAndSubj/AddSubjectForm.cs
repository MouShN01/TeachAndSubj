using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachAndSubj
{
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void addSubject_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(subjTextBox.Text))
                {
                    throw new Exception("Введіть назву предмету");
                }
                Subject subject = new Subject();
                subject.Name = subjTextBox.Text;
                foreach (var chTeach in teachCheckBox.CheckedItems)
                {
                    foreach (var teach in MainForm.Teachers)
                    {
                        if (teach.Name == chTeach.ToString())
                        {
                            subject.sTeachers.Add(teach);
                            teach.sSubjects.Add(subject);
                        }
                    }
                }
                MainForm.Subjects.Add(subject);
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddSubjectForm_Load(object sender, EventArgs e)
        {
            foreach (var teach in MainForm.Teachers)
            {
                teachCheckBox.Items.Add(teach.Name);
            }
        }
    }
}
