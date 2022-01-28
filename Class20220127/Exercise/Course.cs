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
        //public List<Student> Students;//一门课有很多学生，（学生与课程有复杂关系）因为有了第三个类，所以在这里需要删除
        public List<StudentCourse> CourseStudents;
        //public Institute Institute;//课程不能与学校连接
        //public Diploma diploma;//一门课只有一个毕业证（毕业证与学分有复杂关系）（删除）
        public List<DiplomaCourse> DiplomaCourses;
    }
}
