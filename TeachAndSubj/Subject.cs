using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeachAndSubj
{
    public class Subject
    {
        public string Name{ get; set; }
        public List<Teacher> sTeachers { get; set; }

        public Subject() 
        {
            sTeachers = new List<Teacher>();
        }
    }
}
