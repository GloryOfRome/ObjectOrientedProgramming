using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124_自己写
{
    class Student
    {
        /*
         - Create a class "Student" that contains few student properties like (Name, Birthdate, Nationality) and 2 different constructors, one that takes only the name and another one that takes all the fields
        创建一个“学生”类，其中包含一些学生属性，如（姓名、出生日期、国籍）和 2 个不同的构造函数，一个只取名字，另一个取所有字段
         - In the Student class, create another property for Students called "Courses", which is a list of courses that a student is enrolled in
        在Student类中，为Student创建另一个名为“Courses”的属性，这是一个学生注册的课程列表??????
         - In Student class, write two functions, JoinCourse and LeaveCourse to handle the enrollment
        在 Student 类中，编写 JoinCourse 和 LeaveCourse 两个函数来处理注册
         - Also write a function PrintAllCourses in Student class
        还要在 Student 类中编写一个函数 PrintAllCourses
         - Change the Student class so the student can only have 15 credits of courses at the same time
        更改学生班级，使学生只能同时拥有15个学分的课程
         */

        public string Name;
        public DateTime Birthdate;
        public string Nationality;
        public List<Course> courses = new List<Course>();
        public int NumberOfEnrolledCredits;


        public Student(string name)
        {
            this.Name = name;
        }

        public Student(string name, DateTime birthdate, string nationality)
        {
            this.Name = name;
            this.Birthdate = birthdate;
            this.Nationality = nationality;
        }

        public void JoinCourse(Course courseToJoin)
        {
            if (!this.courses.Contains(courseToJoin))
            {
                if(NumberOfEnrolledCredits+courseToJoin.NumberOfCredits<=15)
                    this.courses.Add(courseToJoin);
                else
                    Console.WriteLine("You already reached the max allowed num of credits");
            }
            else
                Console.WriteLine("You are already enrolled in this course");
        }

        public void LeaveCourse()
        {

        }

        public static void PrintAllCourses()
        {

        }
    }
}
