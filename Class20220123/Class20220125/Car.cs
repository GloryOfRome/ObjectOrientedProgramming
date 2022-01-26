using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220125
{
    internal class Car//本项目使用
    {
        public int Id;//Serial Num Vip
        public string Make;//构造，制作
        public string Model;//型号
        public int Year;
        public string Color;

        public bool IsNew;
        public bool IsAutomatic;
        public int Kilometers;

        public double Price;
        public bool IsSold;
        public DateTime TimeOfSale;//生产日期   
        //public int CustomerId;//The Id of the customer who bought/will buy the car购买/将要购买这辆汽车的顾客的Id
        public Customer Customer;

        public Car(int Id, string Make, int Year)
        {
            this.Id = Id;
            this.Make = Make;
            this.Year = Year;
        }
    }
}
