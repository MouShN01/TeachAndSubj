using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO; 

namespace TeachAndSubj
{
    public partial class MainForm : Form
    {
        public static List<Teacher> Teachers  = new List<Teacher>();
        public static List<Subject> Subjects = new List<Subject>();

        public List<Teacher> teacherListView;

        public static Teacher selectedTeacher;
        public static Subject selectedSubject;

        public MainForm()
        {
            InitializeComponent();
            LoadData();
            teacherListView = Teachers;
            BindData();
        }

        private void BindData()
        {

            BindingSource bindTeachers = new BindingSource();
            bindTeachers.DataSource = teacherListView;
            dgvTeachers.DataSource = bindTeachers;
            dgvTeachers.Columns[0].HeaderText = "ПІБ викладача";

            BindingSource bindSubject = new BindingSource();
            bindSubject.DataSource = Subjects;
            dgvSubj.DataSource = bindSubject;
            dgvSubj.Columns[0].HeaderText = "Назва предмету";
        }

        private void SaveData()
        {
            string teachersJson = JsonConvert.SerializeObject(Teachers, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });
            string subjectsJson = JsonConvert.SerializeObject(Subjects, Formatting.Indented,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                });

            File.WriteAllText("teachers.json", teachersJson);
            File.WriteAllText("subjects.json", subjectsJson);
        }

        private void LoadData()
        {
            if (File.Exists("teachers.json"))
            {
                string teachersJson = File.ReadAllText("teachers.json");
                Teachers = JsonConvert.DeserializeObject<List<Teacher>>(teachersJson);
            }

            if (File.Exists("subjects.json"))
            {
                string subjectsJson = File.ReadAllText("subjects.json");
                Subjects = JsonConvert.DeserializeObject<List<Subject>>(subjectsJson);
            }
        }

        private void addTeachBtn_Click(object sender, EventArgs e)
        {
            AddTeacherForm atf = new AddTeacherForm();
            if(atf.ShowDialog() == DialogResult.OK) 
            {
                teacherListView = Teachers;
                BindData();
            }
        }

        private void addSubj_Click(object sender, EventArgs e)
        {
            AddSubjectForm asf = new AddSubjectForm();
            if(asf.ShowDialog() == DialogResult.OK)
            {
                BindData();
            }
        }

        private void showSubjBtn_Click(object sender, EventArgs e)
        {
            var teacherName = dgvTeachers.SelectedRows[0].Cells[0].Value.ToString();
            foreach (var t in Teachers)
            {
                if (teacherName == t.Name)
                {
                    BindingSource bindT = new BindingSource();
                    bindT.DataSource = t.sSubjects;
                    dgvSubj.DataSource = bindT;
                    dgvSubj.Columns[0].HeaderText = teacherName;
                }
            }
        }

        private void showTeachBtn_Click(object sender, EventArgs e)
        {
            var subjName = dgvSubj.SelectedRows[0].Cells[0].Value.ToString();
            foreach(var s in Subjects)
            {
                if (subjName == s.Name)
                {
                    teacherListView = s.sTeachers;
                    dgvTeachers.Columns[0].HeaderText = subjName;
                }
            }
            BindData();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            teacherListView = Teachers;
            BindData();
        }

        private void editTeachBtn_Click(object sender, EventArgs e)
        {
            selectedTeacher = dgvTeachers.SelectedRows[0].DataBoundItem as Teacher;
            EditTeacherForm etf = new EditTeacherForm();
            if (etf.ShowDialog() == DialogResult.OK)
            {
                BindData();
            }
        }

        private void editSubjBtn_Click(object sender, EventArgs e)
        {
            selectedSubject = dgvSubj.SelectedRows[0].DataBoundItem as Subject;
            EditSubjectForm esf = new EditSubjectForm();
            if (esf.ShowDialog() == DialogResult.OK)
            {
                BindData();
            }
        }

        private void sortAlphBtn_Click(object sender, EventArgs e)
        {
            var sortedList = teacherListView.OrderBy(teacher => teacher.Name).ToList();
            teacherListView = sortedList;
            BindData();
        }

        private void sortsubjBtn_Click(object sender, EventArgs e)
        {
            var sortedList = teacherListView.OrderByDescending(teacher => teacher.sSubjects.Count()).ToList();
            teacherListView = sortedList;
            BindData();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveData();
        }

        private void dgvTeachers_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Teacher teacherToDelete = e.Row.DataBoundItem as Teacher;
            foreach(var s in Subjects)
            {
                if(s.sTeachers.Contains(teacherToDelete))
                {
                    s.sTeachers.Remove(teacherToDelete);
                }
            }
        }

        private void dgvSubj_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Subject subjectToDelete = e.Row.DataBoundItem as Subject;
            foreach(var t in Teachers)
            {
                if(t.sSubjects.Contains(subjectToDelete))
                {
                    t.sSubjects.Remove(subjectToDelete);
                }
            }
        }
    }
}
