using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Course
    {
        public string Name;
        public string Duration;//学习时间长短

        //Relation
        public Teacher Teacher;//一门课只有一名老师
        //public List<Student> Students;//一门课有很多学生，因为有了第三个类，所以在这里需要删除
        List<StudentCourse> CourseStudents;
    }
}
