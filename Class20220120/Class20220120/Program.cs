using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AboutAnimal;

namespace Class20220120
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Mike");
            Student st2 = new Student("Chris");

            Course c1 = new Course("DOP", 1, 3);
            Course c2 = new Course("Algorithms", 1, 6);
            Course c3 = new Course("Algorithms2", 2, 4);
            Course c4 = new Course("Algorithms3", 3, 5);

            st1.Nationality = "Canada1";
            st1.Birthdate = new DateTime(1990, 1, 6);//DateTime 必须new
            st1.JoinCourse(c2);
            st1.JoinCourse(c1);
            //st1.JoinCourse(c3);
            //st1.JoinCourse(c4);

            Console.WriteLine("---------------");
            
            

        }
    }
}