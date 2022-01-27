using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class VendingMachine
    {
        public static int SerialNumber;
        private Dictionary<int, int> MoneyFloat;
        private Dictionary<Product, int> Inventory;

        public readonly string Barcode;
       

        public VendingMachine() { }
        public VendingMachine(string barcode)
        {
            SerialNumber++;
            if (barcode == "")
                throw new MyException4("Error: the Serial Number is empty, please modify");
            else
                this.Barcode = barcode;
            MoneyFloat = new Dictionary<int, int>() { { 100, 0 }, { 50, 0 }, { 20, 0 }, { 10, 0 }, { 5, 0 }, { 2, 0 }, { 1, 0 } };
            Inventory = new Dictionary<Product, int>();
        }

        public void AA(Dictionary<int, int> MoneyFloat,int money)
        {
            int[] arr = new int[] { 100, 50, 20, 10, 5, 2, 1 };
            for (int i=0; i < arr.Length; i++)
            {
                int intKey = arr[i];
                int intValue = MoneyFloat[arr[i]];
                while (intValue>0 && intKey <= money)
                {
                    int temp = money / intKey;
                    Console.WriteLine($"{intKey}--{temp}");
                    Console.WriteLine("-----------");
                    intValue -= temp;
                    Console.WriteLine($"{intValue}");
                    money -= intValue * temp;
                }
            }
            foreach(var el in MoneyFloat)
            {
                Console.WriteLine($"{el.Key}--{el.Value}");
            }
        }

        public string StockItem(Product product, int Quantity)
        {
            if (Quantity < 0)
                throw new MyException5("Error: VendingMachine.StockItem should not allow negative quantities, please modify");

            if (this.Inventory.ContainsKey(product))
                this.Inventory[product] += Quantity;
            else
                this.Inventory.Add(product, Quantity);
            return $"The {product.Name} code:{product.Code}, Price: {product.Price} dollars, Quantity: {Quantity} piece";
        }

        public string StockFloat(int MoneyDenomination, int Quantity)
        {
            if (MoneyDenomination < 0 || Quantity<0)
                throw new MyException5("Error: VendingMachine.StockFloat should not allow negative quantities, please modify");

            if (MoneyFloat.ContainsKey(MoneyDenomination))
                MoneyFloat[MoneyDenomination] += Quantity;
            else
                MoneyFloat.Add(MoneyDenomination, Quantity);

            string temp = "The vending machine has the amount: ";
            foreach (var el in MoneyFloat)
                temp += $"{el.Key} dollars: {el.Value} piece; ";
            return temp;
        }

        public string VendItem(string Code, List<int> Money)
        {

            int OutputMoney = 0;

            int tempCustomerMoney = 0;
            foreach(int el in Money)
            {
                tempCustomerMoney += el;
            }

            int tempVedingMachineMoney = 0;
            foreach (var el in MoneyFloat)
            {
                tempVedingMachineMoney += el.Key * el.Value;
            }


            foreach (var el in Inventory)
            {
                if(el.Key.Code==Code && el.Value > 0)
                {
                    if (tempCustomerMoney >= el.Key.Price && tempVedingMachineMoney > (tempCustomerMoney - el.Key.Price))
                    {
                        OutputMoney = tempCustomerMoney-el.Key.Price;
                        
                        Inventory[el.Key] -= 1;

                        return $"Please enjoy your ‘{el.Key.Name}’ and take your change of ${OutputMoney}";
                    }
                    else if(tempCustomerMoney < el.Key.Price)
                    {
                        return "Error: insufficient money provided.";
                    }else if (tempVedingMachineMoney<(tempCustomerMoney- el.Key.Price))
                    {
                        return "Error: I don't have enough change for you.";
                    }
                }else if(el.Key.Code != Code)
                {
                    return $"Error, no item with code “{el.Key.Name}”";
                }else if(el.Value == 0)
                {
                    return "Error: Item is out of stock";
                }
            }
            
            return "Error: insufficient money provided";

        }

        public Dictionary<int, int> OutputMoney(Dictionary<int, int> MoneyFloat, List<int> Money, int tempCustomerMoney)
        {
            foreach(int el in Money)
            {
                if (MoneyFloat.ContainsKey(el))
                    MoneyFloat[el]++;
                else
                    MoneyFloat.Add(el, 1);
            }

            foreach(var el in MoneyFloat)
                Console.WriteLine($"{el.Key}--{el.Value}");

            return MoneyFloat;
        }
    }
}
