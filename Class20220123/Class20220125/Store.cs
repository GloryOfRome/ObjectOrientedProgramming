using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220125
{
    class Store
    {
        List<Car> AllCar = new List<Car>();
        
        public void SellCarToCustomer(Car car)
        {
            //店里有这个车，并且库存数>1，可以销售
            if(AllCar.Contains(car))
                Console.WriteLine("你可以卖这辆车");
        }
    }
}
