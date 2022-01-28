using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Diploma//专业
    {
        public string Name;

        //public Institute Institute;//一个专业只针对一个学校(不对)
        public Department Department;//专业属于某个部门

        public List<DiplomaCourse> DiplomaCourses;
        public List<Student> Students;

        public Diploma(Department department)
        {
            this.Department = department;
            this.Students = new List<Student>();
            this.DiplomaCourses = new List<DiplomaCourse>();
        }

    }
}
