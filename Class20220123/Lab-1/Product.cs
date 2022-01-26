using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Product
    {
        public string Name;
        public int Price;
        public string Code;

        public Product() { }
        public Product(string name, int price, string code)
        {
            this.Name = name;
            this.Price = price;
            this.Code = code;
        }
    }
}
