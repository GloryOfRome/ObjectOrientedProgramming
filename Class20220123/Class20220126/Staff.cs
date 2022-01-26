using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220126
{
    class Staff
    {
        public string Name;
        public DateTime JoinedDate;//入职日期。
        public double BaseSalary;//基本工资

        public Staff() { }

        public Staff(string name, DateTime date, double salary)
        {
            this.Name = name;
            this.JoinedDate = date;
            this.BaseSalary = salary;
        }

        public double CalculateSalary()//获取成员工资
        {
            return BaseSalary;
        }

        public void GetInfo()
        {
            Console.WriteLine($"The employee {this.Name} has been working here since {this.JoinedDate}");
        }
        
    }
    
}
