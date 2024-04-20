using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeachAndSubj
{
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(teacherNameEdit.Text))
                {
                    throw new Exception("Введіть ПІБ викладача");
                }
                Teacher teacher = new Teacher();
                teacher.Name = teacherNameEdit.Text;

                foreach (var chSubj in subjCheckBox.CheckedItems)
                {
                    foreach (var sub in MainForm.Subjects)
                    {
                        if (sub.Name == chSubj.ToString())
                        {
                            teacher.sSubjects.Add(sub);
                            sub.sTeachers.Add(teacher);
                        }
                    }
                }
                MainForm.Teachers.Add(teacher);
                this.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            foreach(var subj in MainForm.Subjects) 
            {
                subjCheckBox.Items.Add(subj.Name);
            }
        }
    }
}
