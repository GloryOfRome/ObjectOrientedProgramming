using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220126
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff = new Staff();

            Teacher teacher = new Teacher();
            teacher.Name = "Tom";
            teacher.JoinedDate = DateTime.Now;
            teacher.GetInfo();
            Console.WriteLine("-------------");
            Console.WriteLine(teacher.CalculateSalary(20.5, 35.5, 3));

            Admin admin = new Admin();
            Console.WriteLine(admin.CalculateSalary(20.5));
        }
    }
}
