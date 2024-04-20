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
    public partial class EditTeacherForm : Form
    {
        public EditTeacherForm()
        {
            InitializeComponent();
        }

        private void EditTeacherForm_Load(object sender, EventArgs e)
        {
            List<int> chkBoxIndx = new List<int>();
            teachNameLabel.Text = MainForm.selectedTeacher.Name;
            foreach (var s in MainForm.Subjects)
            {
                subjChkBox.Items.Add(s.Name);
            }
            foreach (var cs in subjChkBox.Items)
            {
                foreach (var s in MainForm.selectedTeacher.sSubjects)
                {
                    if (cs.ToString() == s.Name)
                    {
                        chkBoxIndx.Add(subjChkBox.Items.IndexOf(cs));
                    }
                }
            }
            foreach (var item in chkBoxIndx)
            {
                subjChkBox.SetItemChecked(item, true);
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            foreach (var s in MainForm.selectedTeacher.sSubjects)
            {
                foreach (var t in s.sTeachers)
                {
                    if (t.Name == MainForm.selectedTeacher.Name)
                    {
                        s.sTeachers.Remove(t);
                        break;
                    }
                }
            }
            MainForm.selectedTeacher.sSubjects.Clear();
            foreach (var chSubj in subjChkBox.CheckedItems)
            {
                foreach (var subj in MainForm.Subjects)
                {
                    if (subj.Name == chSubj.ToString())
                    { 
                        MainForm.selectedTeacher.sSubjects.Add(subj);
                        subj.sTeachers.Add(MainForm.selectedTeacher);
                    }
                }
            }
            this.Close();
        }
    }
}
