using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 100;
            Console.WriteLine(num);
            ChangeMyNumber(num);
            Console.WriteLine($"after:{num}");
            Console.WriteLine("-------------------");

            Student s1 = new Student();
            s1.Namr = "Tom";
            Console.WriteLine(s1.Namr);
            ChangeStudentNationaly(s1);
            Console.WriteLine($"after:{s1.Namr}");
            Console.WriteLine("-------------------");

            string name = "old value";
            Console.WriteLine(name);
            ChangeMyString(name);
            Console.WriteLine($"after:{name}");

        }
        public static void ChangeMyNumber(int num)
        {
            num = 200;
            Console.WriteLine($"method:{num}");
        }

        public static void ChangeStudentNationaly(Student s)
        {
            s.Namr = "Bob";
            Console.WriteLine($"method:{s.Namr}");
        }

        public static void ChangeMyString(string name)
        {
            name = "new value";
            Console.WriteLine($"method:{name}");
        }
    }
    
}
