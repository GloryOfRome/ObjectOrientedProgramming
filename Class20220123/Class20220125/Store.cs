using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220125
{
    internal class Store//Database where we have everything数据库中有我们所有的东西
    {
        public string Name;
        public string Address;
        public int OpeningHour;
        public int ClosingHour;

        public List<Car> AllCars;
        public List<Customer> AllCustomer;
        public Store(string name)
        {
            this.Name = name;
            AllCars = new List<Car>();
            AllCustomer = new List<Customer>();
        }

        public void SellCar(Car car,Customer customer)
        {
            if (car.IsSold)
            {
                Console.WriteLine("The car is already sold");
                return;
            }
            car.IsSold = true;
            car.TimeOfSale = DateTime.Now;//表示“现在”已经卖掉了
            //car.Customer = customer.Id;
            car.Customer = customer;
        }

        public List<Car> GetAllSoldCars()//得到所有已售汽车信息
        {
            List<Car> result = new List<Car>();
            foreach(var car in AllCars)
            {
                if (car.IsSold)
                    result.Add(car);
            }
            return result;
        }
    }
}
