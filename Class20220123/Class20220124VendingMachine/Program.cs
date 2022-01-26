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
            Product pro1 = new Product("bread",2,"A1");
            Product pro2 = new Product("milk", 10, "A2");
            Product pro3 = new Product("apple",5, "A3");

            Console.WriteLine(vend1.StockItem(pro1, 5));
            Console.WriteLine(vend1.StockItem(pro1, 15)); 
            Console.WriteLine(vend1.StockItem(pro3, 5)); 
            Console.WriteLine("--------------------");
            Console.WriteLine(vend1.StockFloat(1, 10));
            Console.WriteLine(vend1.StockFloat(2, 10));
            Console.WriteLine(vend1.StockFloat(100, 10));
            Console.WriteLine("--------------------");

            Console.WriteLine(vend1.StockFloat(1, 10));
            List<int> Money = new List<int>() { 2,5,20 };
            vend1.VendItem("A1", Money);
        }
    }
}
