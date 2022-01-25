using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220124VendingMachine
{
    class VendingMachine
    {
        /*
         Create a class, VendingMachine, which tracks its own money float and item inventory. It should have properties:
         创建一个类 VendingMachine，它跟踪自己的货币浮动和物品库存。它应该具有以下属性：

        Methods (VendingMachine)
        StockItem(Product product, int Quantity) adds a product to the vending machine’s product inventory, including new items or items already in inventory. 
        It should return a string confirming the product name, code, price, and new quantity.
        StockItem(Product product, int Quantity) 将产品添加到自动售货机的产品库存中，包括新商品或已在库存中的商品。
        它应该返回一个确认产品名称、代码、价格和新数量的字符串。

        StockFloat(float MoneyDenomination, int Quantity) adds money pieces of the given denomination to the machine’s change float. It should return a string confirming the entire stock of the float.
        StockFloat(float MoneyDenomination, int Quantity) 将给定面额的货币块添加到机器的找零浮动中。它应该返回一个字符串来确认浮动的整个库存。
        For example, StockFloat(1, 10) adds ten $1 coins to the machine’s change float. It then returns a string listing all of the amounts of money in the float inventory.
        例如，StockFloat(1, 10) 将十个 1 美元硬币添加到机器的零钱浮动中。然后它返回一个字符串，列出浮动库存中的所有金额。
         */

        public int SerialNumber;//机器本身的唯一 ID
        Dictionary<float, int> MoneyFloat = new Dictionary<float, int>() {
            { 1,10 },
            { 2,10 },
            { 5,10 },
            { 10,10 },
            { 20,10 } };//跟踪机器拥有的各种货币数量的字典。
        Dictionary<Product, int> Inventory = new Dictionary<Product, int>();//跟踪机器拥有的每种产品的数量。构造函数应该初始化字典属性，并为其提供一个序列号。


        public void StockItem(Product product, int Quantity)//产品，数量
        {
            //判断自动售货机中产品是否包含此产品，TRUE---inventory的value++，FALSE---inventory.add(产品，1)
            if (this.Inventory.TryGetValue()
            {
                Inventory.Add(product.Code, Inventory.Values++)
            }
            Console.WriteLine($"The price of {product.Name} is {product.Price} dollars. There are {product.Code} of them.");
        }

        public void StockFloat(float MoneyDenomination, int Quantity)
        {
            //判断自动售货机中货币是否包含此面值，TRUE---MoneyFloat的value++，FALSE---inventory.add(货币面值，1)
            //if (MoneyFloat.Keys.Contains<>)

            Console.WriteLine("The current inventory of vending machines is:");
            foreach (var el in MoneyFloat)
                Console.WriteLine($"${el.Key}: {el.Value} piece ");
        }
    }
}
