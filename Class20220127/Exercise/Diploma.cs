using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Diploma//职业课程
    {
        public string Name;

        //public Institute Institute;//一个职业课程只针对一个学校(不对)
        public Department Department;//部门本身开设职业课程

        public List<DiplomaCourse> DiplomaCourses;
        public List<Student> Students;

        public Diploma(Department department)
        {
            this.Department = department;
            this.Students = new List<Student>();
            //DiplomaCourses = new List<DiplomaCourse>();
        }

    }
}
