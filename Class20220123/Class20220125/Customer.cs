using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220125
{
    internal class Customer
    {
        public int Id;
        public string Name;
        public string Address;
        public string PhoneNumber;
        public string Email;

        //Navigation property(not part of the database) 导航属性(不是数据库的一部分)
        public List<Car> car;


        public bool VIP;
        public int CreditScore;//信用评分

        public Customer(string name,string email)
        {
            this.Name = name;
            this.Email = email;
        }
    }
}
