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
            VendingMachine vendingMachine = new VendingMachine();

            vendingMachine.MoneyFloat[1] = 4;

            Product pro1 = new Product("Chocolate - covered Beans", 2, "A12");
            vendingMachine.Inventory.Add(pro1, 3);
            List<int> Money = new List<int>() { 5 };
            Console.WriteLine(vendingMachine.VendItem("A12", Money));
        }
    }
}
