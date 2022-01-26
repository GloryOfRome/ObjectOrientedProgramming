using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCarDealership
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Waverly Mazda");

            Car car1 = new Car(134534534, "Mazda", 2020);
            Car car2 = new Car(282634782, "Honda", 1990);

            store.AllCars.Add(car1);
            store.AllCars.Add(car2);


            Customer customer1 = new Customer("Mike", "mike@google.com");
            Customer customer2 = new Customer("Chris", "chris@yahoo.com");

            store.AllCustomer.Add(customer1);
            store.AllCustomer.Add(customer2);


        }
    }
}
