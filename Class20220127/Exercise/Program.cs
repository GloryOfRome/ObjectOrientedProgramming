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

            Student st1 = new Student();
        }
    }
}
