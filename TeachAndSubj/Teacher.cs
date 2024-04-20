using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAndSubj
{
    public class Teacher
    {
        public string Name { get; set; }
        public List<Subject> sSubjects { get; set; }

        public Teacher() 
        {
            sSubjects = new List<Subject>();
        }
    }
}
