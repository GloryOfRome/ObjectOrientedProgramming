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
            if (name == null || name == "")
                throw new MyException1("Error: the Name is empty, please modify");
            else
                this.Name = name;

            if (price <= 0)
                throw new MyException2("Error: the Price is negative or zero, please modify");
            else
                this.Price = price;

            if (code == null || code == "")
                throw new MyException3("Error: the Code is empty, please modify");
            else
                this.Code = code;
        }
    }
}
