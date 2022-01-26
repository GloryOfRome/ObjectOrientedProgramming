using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCarDealership
{
    internal class Customer
    {
        public int Id;
        public string Name;
        public string Address;
        public string PhoneNumber;
        public string Email;

        //Navigation property (not part of the database)
        public List<Car> Car;
        

        public bool VIP;
        public int CreditScore;

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
