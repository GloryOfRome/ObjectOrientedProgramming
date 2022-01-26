using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220126
{
    class Admin : Staff//行政
    {
        public string Role;//HR,Admission....
        public Admin(string name, DateTime date, double salary):base(name, date, salary)
        {
            //因为是继承，所以里面的东西都可以省略
        }

        public double CalculateSalary()
        {
            double baseSalary = base.CalculateSalary();
            double duration = (DateTime.Now - this.JoinedDate).TotalDays;//转换成日数
            int adminYearsWorked = (int)duration / 365;//int.Parse()字符串转int用此方法,此处是强行转换
            return baseSalary + (baseSalary * 0.05 * adminYearsWorked);
        }
    }
}
