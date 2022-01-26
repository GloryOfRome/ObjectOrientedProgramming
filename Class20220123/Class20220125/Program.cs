using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220125
{
    class Program
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

            Store store = new Store("Waverly Mazda");

            Car car1 = new Car(134534534,"Mazda", 2020);
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
