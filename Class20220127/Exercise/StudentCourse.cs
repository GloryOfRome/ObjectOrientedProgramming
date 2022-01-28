using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class StudentCourse
    {
        //一个学生有很多课，同时一门又有很多学生。
        public Student Student;
        public Course Course;

        //同时存在于Student和Course之间
        public int Grade;//成绩
        public bool IsReturnStudent;//是返校生
        public DateTime EnrollmentDate;//注册日期

    }
}
