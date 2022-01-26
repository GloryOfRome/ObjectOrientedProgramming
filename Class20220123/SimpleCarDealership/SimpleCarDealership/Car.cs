using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCarDealership
{
    internal class Car
    {
        public int Id; //Serial Num, VIN
        public string Make;
        public string Model;
        public int Year;
        public string Color;
        
        public bool IsNew;
        public bool IsAutomatic;
        public int Kilometers;

        public double Price;
        public bool IsSold;
        public DateTime TimeOfSale;
        //public int CustomerId; // The Id of the customer who bought/will buy the car
        public Customer Customer;

        public Car(int Id, string Make, int Year)
        {
            this.Id = Id;
            this.Make = Make;
            this.Year = Year;

        }
    }
}
