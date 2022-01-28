using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Institute//研究所
    {
        public List<Student> students { get; set; }

        //public List<Course> Courses { get; set; }//学校与课程不能连接
        //public List<Diploma> Diplomas { get; set; }//学校不能与文凭链接
        public List<Department> Departments { get; set; }

        public List<Teacher> Teachers { get; set; }

        public Institute()//学校一旦建立，就需要有部门和老师
        {
            Departments = new List<Department>();
            Teachers = new List<Teacher>();
        }
    }
}
