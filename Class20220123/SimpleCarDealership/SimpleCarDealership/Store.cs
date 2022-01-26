using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCarDealership
{
    internal class Store // Database where we have everything
    {
        public string Name;
        public string Address;
        public int OpeningHour;
        public int ClosingHour;

        public List<Car> AllCars;
        public List<Customer> AllCustomer;
        public Store(string name)
        {
            Name = name;
            AllCars = new List<Car>();
            AllCustomer = new List<Customer>();
        }

        public void SellCar(Car car, Customer customer)
        {
            if(car.IsSold)
            {
                Console.WriteLine("The Car is already sold");
                return;
            }
            car.IsSold = true;
            car.TimeOfSale = DateTime.Now;
            //car.CustomerId = customer.Id;
            car.Customer = customer;

        }
        public List<Car> GetAllSoldCars()
        {
            List<Car> result = new List<Car>();
            foreach(var car in AllCars)
            {
                if(car.IsSold)
                    result.Add(car);
            }
            return result;
        }
    }
}
