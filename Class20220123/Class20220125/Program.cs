using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220125
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 定义错误
            //测试try，catch，finally，throw
            //Console.WriteLine(DivideTwoNumbers());//1-1

            //int res;//1-2
            //// int times = Division(20, 0, out res);
            //int times = Division(20, 10, out res);
            //Console.WriteLine(res);//输出结果为2
            //Console.WriteLine(times);//times????


            //Car car1 = new Car("Toyota", "black", "Japan",  10);
            //car1.ProductionDate = new DateTime(2020, 1, 6);

            //Store
            #endregion
            /*
             * 第一次（1-25）
             a small car dealership wants to create a console app for their operations
             一家小型汽车经销商想要为其运营创建控制台应用程序
              -Create a class "Car", try to decide what are the properties of a car (no methods required) 
              -创建一个“汽车”类，尝试确定汽车的属性（不需要方法）
              -Create a class "Store" that has a list of all cars. 
              - 创建一个包含所有汽车列表的“商店”类。
              -we were toLd that the Brand" of a car is nore than a string, Create a class Brand" and decide what properties this class should have. 
              -我们被告知汽车的品牌“不仅仅是一个字符串，创建一个类品牌”并决定这个类应该具有哪些属性。
              -Create class Customer- 创建类客户
              -In the Store class, write a nethod to sell a car to a custoner
              在 Store 类中，编写一个将汽车卖给客户的方法
              -In the Store class, write a method to get a list of all the sold cars.
              在 Store 类中，编写一个方法来获取所有已售汽车的列表。
              -In the Store class, write a method to get a list of all the sold cars in a nonth (pass the month and year as paraneters). 
              在 Store 类中，编写一个方法来获取所有已售汽车的列表（将月份和年份作为参数传递）。
             */
            Store store = new Store("Waverly Mazda");

            Car car1 = new Car(134534534, "Mazda", 2020);
            Car car2 = new Car(282634782, "Honda", 1990);

            store.AllCars.Add(car1);
            store.AllCars.Add(car2);


            Customer customer1 = new Customer("Mike", "mike@google.com");
            Customer customer2 = new Customer("Chris", "chris@yahoo.com");

            store.AllCustomer.Add(customer1);
            store.AllCustomer.Add(customer2);


        }

        static int Division(int num1, int num2, out int res)
        {
            int times = 0;
            try
            {
                res = num1 / num2;
                return times;
            }
            catch (Exception ex)
            {
                res = 0;
                return times--;

            }
            finally
            {
                times++;
            }

        }

        //1-1
        public static double DivideTwoNumbers()
        {
            try
            {
                Console.WriteLine("Please enter two number");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                return num1 / num2;
            }
            //catch
            //{
            //    Console.WriteLine("Error");
            //    return -1;
            //}
            catch(FormatException e)
            {
                Console.WriteLine("Please don't enter a non value");
                return 0;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Please don't enter zero");
                return 0;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }
            finally
            {
                Console.WriteLine("I am finally");
            }

        }
    }
}
