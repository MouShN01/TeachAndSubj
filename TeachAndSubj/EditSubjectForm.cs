using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TeachAndSubj
{
    public partial class EditSubjectForm : Form
    {
        public EditSubjectForm()
        {
            InitializeComponent();
        }

        private void EditSubjectForm_Load(object sender, EventArgs e)
        {
            List<int> chkBoxIndx = new List<int>();
            subjNameLabel.Text = MainForm.selectedSubject.Name;
            foreach (var t in MainForm.Teachers)
            {
                teachChkbox.Items.Add(t.Name);
            }
            foreach (var ct in teachChkbox.Items)
            {
                foreach(var t in MainForm.selectedSubject.sTeachers)
                {
                    if(ct.ToString() == t.Name)
                    {
                        chkBoxIndx.Add(teachChkbox.Items.IndexOf(ct));
                    }
                }    
            }
            foreach(var item in chkBoxIndx) 
            {
                teachChkbox.SetItemChecked(item, true);
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            foreach(var t in MainForm.selectedSubject.sTeachers)
            {
                foreach(var s in t.sSubjects) 
                {
                    if(s.Name == MainForm.selectedSubject.Name)
                    {
                        t.sSubjects.Remove(s);
                        break;
                    }
                }
            }
            MainForm.selectedSubject.sTeachers.Clear();
            foreach (var chTeach in teachChkbox.CheckedItems)
            {
                foreach (var teach in MainForm.Teachers)
                {
                    if (teach.Name == chTeach.ToString())
                    {
                        MainForm.selectedSubject.sTeachers.Add(teach);
                        teach.sSubjects.Add(MainForm.selectedSubject);
                    }
                }
            }
            this.Close();
        }
    }
}
