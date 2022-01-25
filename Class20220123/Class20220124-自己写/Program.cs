using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124_自己写
{
    class Program
    {
        static void Main(string[] args)
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
              更改学生班级，使学生只能同时拥有15个学分的课程
             */

            Student st1 = new Student("Mike");
            Student st2 = new Student("Chris");
            Student st3 = new Student("Chris");
            Student st4 = new Student("Chris");
            Student st5 = new Student("Chris");
            Console.WriteLine("显示系统中学生人数");
            Console.WriteLine(Student.NumOfStudentsInTheSystem);
            Student.PrintTotalNumOfStudents();

            Course c1 = new Course("OOP", 1, 3);
            Course c2 = new Course("Algorithms", 1, 6);

            st1.Nationality = "Canada";
            st1.Birthdate = new DateTime(1990, 1, 6);

            st1.JoinCourse(c1);
            st1.JoinCourse(c2);
            Console.WriteLine("当我想加入已经加入的课程");
            st1.JoinCourse(c2);
            Console.WriteLine("打印st1已经参加的课程");
            st1.PrintAllCourses();

            Console.WriteLine("离开课程c1---OOP后");
            st1.LeaveCourse(c1);
            Console.WriteLine("再次打印st1已经参加的课程");
            st1.PrintAllCourses();

            Console.WriteLine("在此希望加入c1---OOP后");
            st1.JoinCourse(c1);
            Console.WriteLine("---------------------");

            //TestStaticClass obj = new TestStaticClass();//由于class -Student中定义类用static
            Console.WriteLine($"测试静态类之前的值{TestStaticClass.i}");
            TestStaticClass.i = 10;
            Console.WriteLine($"测试静态类之后的值{TestStaticClass.i}");



            Console.WriteLine("---------------------");
            st2.JoinCourse(c2);
            st2.PrintAllCourses();
        }
    }
}
