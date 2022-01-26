using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class VendingMachine
    {
        public int SerialNumber;//机器本身的唯一 ID
        public Dictionary<int, int> MoneyFloat = new Dictionary<int, int>() {
            {1,0 },
            {2,0 },
            {5,0 },
            {10,0 },
            {20,0 },
            {50,0 },
            {100,0 },
        };//跟踪机器拥有的各种货币数量的字典。
        public Dictionary<Product, int> Inventory = new Dictionary<Product, int>();//跟踪机器拥有的每种产品的数量。

        public VendingMachine() { }
        public VendingMachine(int serialNumber)//构造函数应该初始化字典属性，并为其提供一个序列号。
        {
            this.SerialNumber = serialNumber;
        }

        public void AA()
        {
            int tempVedingMachineMoney = 0;
            foreach (var el in MoneyFloat)
            {
                tempVedingMachineMoney += el.Key * el.Value;
            }
            Console.WriteLine($"总金额{tempVedingMachineMoney}");
        }

        //将产品添加到自动售货机的产品库存中，包括新商品或已在库存中的商品。它应该返回一个确认产品名称、代码、价格和新数量的字符串。
        public string StockItem(Product product, int Quantity)//商品，数量
        {
            //判断Inventory中是否有商品product TRUE--增加库存，FALSE--添加商品
            if (this.Inventory.ContainsKey(product))
                this.Inventory[product] += Quantity;
            else
                this.Inventory.Add(product, Quantity);
            return $"The {product.Name} code:{product.Code}, Price: {product.Price} dollars, Quantity: {Quantity} piece";
        }

        //将给定面额的货币块添加到机器的找零浮动中。它应该返回一个字符串来确认浮动的整个库存。
        public string StockFloat(int MoneyDenomination, int Quantity)
        {
            //判断MoneyFloat是否由此面额的钱，TRUE--添加数量，FALSE--添加此面额的钱和数量
            if (MoneyFloat.ContainsKey(MoneyDenomination))
                MoneyFloat[MoneyDenomination] += Quantity;
            else
                MoneyFloat.Add(MoneyDenomination, Quantity);

            string temp = "The vending machine has the amount: ";
            foreach (var el in MoneyFloat)
                temp += $"{el.Key} dollars: {el.Value} piece; ";
            return temp;
        }

        public string VendItem(string Code, List<int> Money)//向机器提供产品代码和提供的钱币列表。
        {
            //给顾客的钱
            int OutputMoney = 0;
            //顾客投入的总金额
            int tempCustomerMoney = 0;
            foreach(int el in Money)
            {
                tempCustomerMoney += el;
            }

            //自动售货机的总金额
            int tempVedingMachineMoney = 0;
            foreach (var el in MoneyFloat)
            {
                tempVedingMachineMoney += el.Key * el.Value;
            }

            //找到具有机器产品库存中给出的代码的产品，确保它有库存，然后确保提供的资金足以支付产品的费用。
            //它会出售所需的零钱（如果有），并减少库存中该物品的数量和退回的零钱。
            foreach (var el in Inventory)
            {
                if(el.Key.Code==Code && el.Value > 0)
                {
                    if (tempCustomerMoney >= el.Key.Price && tempVedingMachineMoney > (tempCustomerMoney - el.Key.Price))
                    {
                        OutputMoney = tempCustomerMoney-el.Key.Price;
                        //自动售货机-金额减少
                        //MoneyFloat = tempVedingMachineMoney + tempCustomerMoney - el.Key.Price;
                        //自动售货机-商品减少
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

        public void OutputMoney(Dictionary<int, int> MoneyFloat, List<int> Money, int tempCustomerMoney)
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

            //int[] arr = new int[] { 1, 2, 5, 10, 20, 50, 100 };

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    int temp = OutputMoney / arr[i];
            //    if (OutputMoney != 0)
            //    {
            //        if (temp > MoneyFloat[arr[i]])
            //        {
            //            MoneyFloat[arr[i]]-=temp;
            //        }
            //    }
            //}
            //foreach (var el in MoneyFloat)
            //    Console.WriteLine($"Key: {el.Key}, Value: {el.Value}");

            //return result;
        }
    }
}
