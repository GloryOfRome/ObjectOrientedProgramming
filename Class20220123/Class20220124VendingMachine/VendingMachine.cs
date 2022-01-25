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


        VendItem(string Code, List<float> Money) provides a product code to the machine and a list of money pieces provided. 
        VendItem(string Code, List<float> Money) 向机器提供产品代码和提供的钱币列表。
        It finds that product with the code given in the machine’s product inventory, ensures that it is in stock, and then ensures that the money provided is sufficient to pay for the product. 
        它找到具有机器产品库存中给出的代码的产品，确保它有库存，然后确保提供的资金足以支付产品的费用。
        It then vends the required change, if any, and reduces the quantity of that item in inventory and the returned change.
        然后，它会出售所需的零钱（如果有），并减少库存中该物品的数量和退回的零钱。
        The method returns a string appropriate to whatever has occurred. (ie. “Error, no item with code “E17”, “Error: Item is out of stock”, “Error: insufficient money provided”, “Please enjoy your ‘Jelly Beans’ and take your change of $0.60”).
        该方法返回一个适合任何已发生的字符串。 （即“错误，没有代码为“E17”的商品，“错误：商品缺货”，“错误：提供的资金不足”，“请享用您的‘果冻豆’并取走您的零钱$0.60”）。
        For example, in Inventory is the key-value pair {{“Chocolate-covered Beans”, 2, “A12”}, 3}. MoneyFloat has four $1 coins (ie. {1, 4}).
        VendItem(“A12”, {5}) represents entering the code “A12” and inserting a $5 bill into the machine.
        例如，在 Inventory 中是键值对 {{“Chocolate-covered Beans”, 2, “A12”}, 3}。 MoneyFloat 有四个 1 美元硬币（即 {1, 4}）。
        VendItem(“A12”, {5}) 表示输入代码“A12”并将一张 5 美元的钞票插入机器。
        The machine reduces the value in the inventory for the product that has the key of A12, and returns three $1 coins.
        As a result, Inventory now has the key-value pair of { {“Chocolate-covered Beans, 2, “A12”}, 2} and MoneyFloat has the key-value pair of {1, 1}.
        机器减少具有 A12 密钥的产品的库存价值，并返回三个 1 美元硬币。
        因此，Inventory 现在具有 { {“Chocolate-covered Beans, 2, “A12”}, 2} 的键值对，而 MoneyFloat 具有 {1, 1} 的键值对。
         */

        public int SerialNumber;//机器本身的唯一 ID
        public Dictionary<float, int> MoneyFloat = new Dictionary<float, int>() {
            { 1,10 },
            { 2,10 },
            { 5,10 },
            { 10,10 },
            { 20,10 } };//跟踪机器拥有的各种货币数量的字典。
        public Dictionary<Product, int> Inventory = new Dictionary<Product, int>();//跟踪机器拥有的每种产品的数量。
        
        public VendingMachine()
        {

        }

        //构造函数应该初始化字典属性，并为其提供一个序列号。
        public VendingMachine(int serialNumber)
        {
            this.SerialNumber = serialNumber;
        }


        //StockItem(Product product, int Quantity) 将产品添加到自动售货机的产品库存中，包括新商品或已在库存中的商品。
        //它应该返回一个确认产品名称、代码、价格和新数量的字符串。
        public void StockItem(Product product, int Quantity)//产品，数量
        {
            //判断自动售货机中产品是否包含此产品，TRUE---inventory的value++，FALSE---inventory.add(产品，1)
            if (Inventory.ContainsKey(product))
                Inventory[product]+= Quantity;
            else
                Inventory.Add(product, Quantity);
            Console.WriteLine("----------------");
            //foreach (var el in Inventory)//检查是否将数据存入Dictionary
            //    Console.WriteLine($"key:{el.Key.Name},value： {el.Value}");
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price} dollars, Code: {product.Code}, Quantity:{Inventory[product]}");

            ///此处问题：无法把相同商品的数量相加？？？？？？？？？？？？？？？？？？？？？？？？？？？
        }


        /*
        StockFloat(float MoneyDenomination, int Quantity) adds money pieces of the given denomination to the machine’s change float. It should return a string confirming the entire stock of the float.
        StockFloat(float MoneyDenomination, int Quantity) 将给定面额的货币块添加到机器的找零浮动中。它应该返回一个字符串来确认浮动的整个库存。
        For example, StockFloat(1, 10) adds ten $1 coins to the machine’s change float. It then returns a string listing all of the amounts of money in the float inventory.
        例如，StockFloat(1, 10) 将十个 1 美元硬币添加到机器的零钱浮动中。然后它返回一个字符串，列出浮动库存中的所有金额。 
        */
        public void StockFloat(float MoneyDenomination, int Quantity)
        {
            //判断自动售货机中货币是否包含此面值，TRUE---MoneyFloat的value++，FALSE---inventory.add(货币面值，1)
            if (MoneyFloat.Keys.Contains<float>(MoneyDenomination))
                MoneyFloat[MoneyDenomination] += Quantity;
            else
                MoneyFloat.Add(MoneyDenomination, Quantity);

                Console.WriteLine("The current inventory of vending machines is:");
            foreach (var el in MoneyFloat)
                Console.WriteLine($"${el.Key}: {el.Value} piece ");
        }

        /*
        VendItem(string Code, List<float> Money) provides a product code to the machine and a list of money pieces provided. 
        VendItem(string Code, List<float> Money) 向机器提供产品代码和提供的钱币列表。

        It finds that product with the code given in the machine’s product inventory, ensures that it is in stock, and then ensures that the money provided is sufficient to pay for the product. 
        它找到具有机器产品库存中给出的代码的产品，确保它有库存，然后确保提供的资金足以支付产品的费用。
        It then vends the required change, if any, and reduces the quantity of that item in inventory and the returned change.
        然后，它会出售所需的零钱（如果有），并减少库存中该物品的数量和退回的零钱。
        The method returns a string appropriate to whatever has occurred. (ie. “Error, no item with code “E17”, “Error: Item is out of stock”, “Error: insufficient money provided”, “Please enjoy your ‘Jelly Beans’ and take your change of $0.60”).
        该方法返回一个适合任何已发生的字符串。 （即“错误，没有代码为“E17”的商品，“错误：商品缺货”，“错误：提供的资金不足”，“请享用您的‘果冻豆’并取走您的零钱$0.60”）。
        For example, in Inventory is the key-value pair {{“Chocolate-covered Beans”, 2, “A12”}, 3}. MoneyFloat has four $1 coins (ie. {1, 4}).
        VendItem(“A12”, {5}) represents entering the code “A12” and inserting a $5 bill into the machine.
        例如，在 Inventory 中是键值对 {{“Chocolate-covered Beans”, 2, “A12”}, 3}。 MoneyFloat 有四个 1 美元硬币（即 {1, 4}）。
        VendItem(“A12”, {5}) 表示输入代码“A12”并将一张 5 美元的钞票插入机器。
        The machine reduces the value in the inventory for the product that has the key of A12, and returns three $1 coins.
        As a result, Inventory now has the key-value pair of { {“Chocolate-covered Beans, 2, “A12”}, 2} and MoneyFloat has the key-value pair of {1, 1}.
        机器减少具有 A12 密钥的产品的库存价值，并返回三个 1 美元硬币。
        因此，Inventory 现在具有 { {“Chocolate-covered Beans, 2, “A12”}, 2} 的键值对，而 MoneyFloat 具有 {1, 1} 的键值对。
         */

        public void VendItem(string Code, List<float> Money)
        {
            if(Inventory.Keys.Contains<string>(Code))
        }
    }
}
