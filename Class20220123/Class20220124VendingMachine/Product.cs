using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124VendingMachine
{
    class Product
    {
        /*
         Create another class, Product, which consists of Name, Price, and Code properties. It should have an appropriate constructor.
         创建另一个类 Product，它由 Name、Price 和 Code 属性组成。它应该有一个适当的构造函数。
         */

        public string Name;
        public int Price;
        public int Code;

        public Product()
        {
            
        }

        public Product(string name, int price, int code)
        {
            this.Name = name;
            this.Price = price;
            this.Code = code;

        }
    }
}
