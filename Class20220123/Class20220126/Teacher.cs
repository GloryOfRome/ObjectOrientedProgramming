using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220126
{
    class Teacher: Staff
    {
        public List<Course> Courses;

        public Teacher() { }

        public Teacher(string name,DateTime date,double salary) : base(name, date, salary)
        {
            this.Courses = new List<Course>();
        }
        public double CalculateSalary()//获取成员工资
        {
            double initialSalary = base.CalculateSalary();
            double teachingSalary = 0;
            foreach(var course in Courses)
            {
                teachingSalary += course.HourlyRate * course.Duration * 180;//180是每月工作时间
            }
            return initialSalary+ teachingSalary;
        }
    }
}
