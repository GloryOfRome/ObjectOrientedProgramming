using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Student
    {
        public int Id;
        public string Name;

        //Relation
        //public List<Course> Courses;//一个学生有很多课，因为有了第三个类，所以在这里需要删除
        List<StudentCourse> StudentCourses;//因为上面的代码取消，但是关系依然存在，所以要把它连接到第三个类
    }
}
