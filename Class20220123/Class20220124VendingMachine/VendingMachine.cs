using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124VendingMachine
{
    class VendingMachine
    {
        public int SerialNumber;
        public Dictionary<int, int> MoneyFloat = new Dictionary<int, int>() {
            { 1,10 },
            { 2,10 },
            { 5,10 },
            { 10,10 },
            { 20,10 } };
        public Dictionary<Product, int> Inventory = new Dictionary<Product, int>();
        

        public VendingMachine(int serialNumber)
        {
            this.SerialNumber = serialNumber;
        }



        public string StockItem(Product product, int Quantity)
        {
            if (Inventory.ContainsKey(product))
                Inventory[product]+= Quantity;
            else
                Inventory.Add(product, Quantity);
            return $"Name: {product.Name}, Price: {product.Price} dollars, Code: {product.Code}, Quantity:{Inventory[product]}";
            
        }

        
        public string StockFloat(int MoneyDenomination, int Quantity)
        {
            //判断自动售货机中货币是否包含此面值，TRUE---MoneyFloat的value++，FALSE---inventory.add(货币面值，1)
            if (MoneyFloat.ContainsKey(MoneyDenomination))
                MoneyFloat[MoneyDenomination] += Quantity;
            else
                MoneyFloat.Add(MoneyDenomination, Quantity);

                Console.WriteLine("The current inventory of vending machines is:");
            //foreach (var el in MoneyFloat)//测试结果
            //    Console.WriteLine($"${el.Key}: {el.Value} piece ");
            return $"${MoneyDenomination} dollars: {MoneyFloat[MoneyDenomination]}";
        }

        public string VendItem(string Code, List<int> Money)
        {

            int userPayment = 0;
            foreach (int el in Money)
                userPayment += el;

            Product productItem = new Product();
            foreach (var el in Inventory)
            {
                if (el.Key.Code==Code)
                {
                    productItem = el.Key;
                    break;
                }
            }

            if (productItem == null)
                return $"Error, no item with code “{Code}”.";
            if (!Inventory.ContainsKey(productItem))
                return $"Error, no item with code “{Code}”.";
            else if (Inventory[productItem] < 0)
                return "Error: Item is out of stock";
            if (productItem.Price > userPayment)
                return "Error: insufficient money provided";

            int remainingChange = userPayment - productItem.Price;
            if (remainingChange == 0)
            {
                Inventory[productItem]--;
                return $"Please enjoy your ‘{productItem.Name}’ ";
            }

            if (remainingChange > 0)
            {
                return $"you can get {OutputMoney(MoneyFloat, userPayment, productItem.Price)}";
            }
            else
            {
                return "you are wrong";
            }
        }
        static int OutputMoney(Dictionary<int, int> dict, int inputMoney, int itemPrice)
        {

            int[] arr = new int[] { 1, 2, 5, 10, 20 };
            Dictionary<int, int> result = new Dictionary<int, int>
             {
                 {1,0 },
                 {2,0 },
                 {5,0 },
                 {10,0 },
                 {20,0 }
             };
            int outputMoney = inputMoney - itemPrice;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int temp = outputMoney / arr[i];
                if (outputMoney != 0)
                {
                    if (temp > dict[arr[i]])
                    {
                        temp = dict[arr[i]];
                    }
                    result[arr[i]] = temp;
                    dict[arr[i]] -= temp;
                    outputMoney = outputMoney - arr[i] * temp;
                }
            }
            Console.WriteLine("In the vending machine");
            foreach (var el in dict)
                Console.WriteLine($"The number of {el.Key}'s is {el.Value}");

            Console.WriteLine("To the customer's");
            int get = 0;
            foreach (var el in result)
            {
                if (el.Value > 0)
                {
                    get += el.Key * el.Value;
                }
            }
            Console.WriteLine($"Please enjoy your and take your change of ${get}");
            return get;
        }


    }
}
