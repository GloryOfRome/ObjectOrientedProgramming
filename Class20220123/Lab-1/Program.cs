using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //VendingMachine vendingMachine = new VendingMachine();
            //vendingMachine.StockFloat(1, 4);
            
            //Product pro = new Product("Chocolate - covered Beans", 2, "A12");
            //vendingMachine.StockItem(pro, 3);
            //List<int> Money = new List<int>() { 5 };
            //Console.WriteLine(vendingMachine.VendItem("A12", Money));
            //Console.WriteLine("------------");
            //Product pp = new Product();
            try
            {
                Product pro1 = new Product("egg", 1, "A01");
                Product pro2 = new Product("apple", 2, "A02");
                Product pro3 = new Product("orange", 3, "A03");

                VendingMachine ve1 = new VendingMachine("60001");
                ve1.StockItem(pro1, 2);
                ve1.StockFloat(-20, 5);
            }
            catch (MyException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
