using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //问题一
            //Institutes have different Prograns (Diploma, EdProgran). Courses are not connected directly to Institutes, 
            //学院有不同的项目(毕业文凭, edprogram)，课程不直接连接到学院
            //They are Connected via their programs (a Course can be in one Progran onlv)
            //通过它们的连接(一个课程只能在一个项目中)

            //问题二
            //Add a class Department (Departments has many Prograns) 
            //添加一个类部门(部门有很多项目)
            //Courses can be in multiple  Programs 
            //课程可以在多个项目

            Institute mitt = new Institute();
            Department IT = new Department(mitt);//重写重写构造函数后需要添加参数

            mitt.Departments.Add(IT);

            Diploma SoftwarDeveloper = new Diploma(IT);//重写重写构造函数后需要添加参数
            IT.Diplomas.Add(SoftwarDeveloper);

            Student st1 = new Student(SoftwarDeveloper);//重写重写构造函数后需要添加参数
            Student st2 = new Student(SoftwarDeveloper);//重写重写构造函数后需要添加参数

            SoftwarDeveloper.Students.Add(st1);
            SoftwarDeveloper.Students.Add(st2);

            Course oop = new Course();//面向对象

            //We want to Link oop with software developer program 
            //我们想与软件开发程序链接oop
            DiplomaCourse oopInSoftwarDeveloper = new DiplomaCourse(SoftwarDeveloper, oop, false, 3);//重写构造函数后效果与下面的一样
            //oopInSoftwarDeveloper.Course = oop;//课程
            //oopInSoftwarDeveloper.Diploma = SoftwarDeveloper;//专业
            //oopInSoftwarDeveloper.IsOptional = false;
            //oopInSoftwarDeveloper.NumOfCredits = 3;

            Course creativeWriting = new Course();//创意写作

            DiplomaCourse cwInSoftwarDeveloper = new DiplomaCourse(SoftwarDeveloper, creativeWriting, true,1);
            //cwInSoftwarDeveloper.Course = creativeWriting;
            //cwInSoftwarDeveloper.Diploma = SoftwarDeveloper;
            //cwInSoftwarDeveloper.IsOptional = true;
            //cwInSoftwarDeveloper.NumOfCredits = 1;

            SoftwarDeveloper.DiplomaCourses.Add(oopInSoftwarDeveloper);
            SoftwarDeveloper.DiplomaCourses.Add(cwInSoftwarDeveloper);

            oop.DiplomaCourses.Add(oopInSoftwarDeveloper);

            creativeWriting.DiplomaCourses.Add(cwInSoftwarDeveloper);

            //Write a method that gets alt the optional courses in a diploma
            ////编写一个方法来替换文凭中的选修课
        }
        public List<string> GetAllOptionalCoursesInADiploma(Diploma diploma)
        {
            List<string> optionalCourses = new List<string>();
            foreach (var diplomaCourse in diploma.DiplomaCourses)
            {
                if (diplomaCourse.IsOptional)
                    optionalCourses.Add(diplomaCourse.Course.Name);
            }

            return optionalCourses;
        }
    }
}
