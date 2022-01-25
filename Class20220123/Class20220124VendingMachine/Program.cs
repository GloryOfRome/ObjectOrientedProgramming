using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vend1 = new VendingMachine(20221001);
            Product pro1 = new Product("巧克力",2,"A1");
            Product pro2 = new Product("巧克力",2, "A1");
            Product pro3 = new Product("apple",5, "A2");
            Product pro4 = new Product("orange",3, "A3");
            Product pro5 = new Product("milk",10, "A4");

            vend1.StockItem(pro1, 5);
            vend1.StockItem(pro2, 15);
            vend1.StockItem(pro3, 5);
            Console.WriteLine("--------------------");
            vend1.StockFloat(1, 10);
            vend1.StockFloat(2, 10);
            vend1.StockFloat(100, 10);


        }
    }
}
