using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220120
{
    class Student
    {
        /*
             - Create a class "Student" that contains few student properties like (Name, Birthdate, Nationality) and 2 different constructors, one that takes only the name and another one that takes all the fields
             创建一个“学生”类，其中包含一些学生属性，如（姓名、出生日期、国籍）和 2 个不同的构造函数，一个只取名字，另一个取所有字段
             
            - Create another class called "Course", a course has a Name, Duration in months, and number of credits.
             创建另一个名为“课程”的课程，课程有名称、持续时间（以月为单位）和学分数。
             
            - In the Student class, create another property for Students called "Courses", which is a list of courses that a student is enrolled in
             在Student类中，为Student创建另一个名为“Courses”的属性，这是一个学生注册的课程列表

             - In Student class, write two functions, JoinCourse and LeaveCourse to handle the enrollment
             在 Student 类中，编写 JoinCourse 和 LeaveCourse 两个函数来处理注册

             - Also write a function PrintAllCourses in Student class
             还要在 Student 类中编写一个函数 PrintAllCourses
             - Change the Student class so the student can only have 15 credits of courses at the same time
             更改学生班级，使学生同时只能拥有15个学分的课程
         */
        public string Name;
        public string Nationality;
        public DateTime Birthdate;
        public List<Course> Courses = new List<Course>();//将报名的课程存入
        public int NumOfEnrolledCredits;//注册学分数


        public Student(string name)
        {
            this.Name = name;
            NumOfEnrolledCredits = 0;
        }

        public Student(string name, DateTime birthdate, string nationality)
        {
            this.Name = name;
            this.Nationality = nationality;
            this.Birthdate = birthdate;
            NumOfEnrolledCredits = 0;

        }

        public void JoinCourse(Course courseToJoin)
        {
            if (!this.Courses.Contains(courseToJoin))
            {
                if (NumOfEnrolledCredits + courseToJoin.NumOfCredits <= 15)
                {
                    this.Courses.Add(courseToJoin);
                    this.NumOfEnrolledCredits += courseToJoin.NumOfCredits;
                }
                else
                    Console.WriteLine("You already reached the max allowed num of credits");//你已经达到了允许的最大积分数
            }
            else
                Console.WriteLine("You are already enrolled in this course");
        }

        public void LeaveCourse(Course courseToLeave)//删除这门课程
        {
            if (this.Courses.Contains(courseToLeave))
            {
                this.Courses.Remove(courseToLeave);
                this.NumOfEnrolledCredits -= courseToLeave.NumOfCredits;
            }
            else
            {
                Console.WriteLine("ERROR....You are not enrolled in this course");//错误……你没有选修这门课
            }
        }

        public void PrintCourses()
        {
            Console.WriteLine($"Courses of student {this.Name}");
            foreach(var course in this.Courses)
                Console.WriteLine(course.Name);
        }
    }
    class Course
    {
        public string Name;
        public int Duration;//持续时间（以月为单位
        public int NumOfCredits;//学生得分

        public Course(string name, int duration, int numOfCredits)
        {
            this.Name = name;
            this.Duration = duration;
            this.NumOfCredits = numOfCredits;//学分的数量
        }
    }
}
