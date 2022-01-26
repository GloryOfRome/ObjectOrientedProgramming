using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 之前的作业
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>()
             {
                 {1,10 },
                 {2,10 },
                 {5,10 },
                 {10,10 },
                 {20,10 }
             };
            int inputMoney = 325;
            int itemPrice = 2;

            OutputMoney(dict, inputMoney, itemPrice);
        }

        static void OutputMoney(Dictionary<int, int> dict, int inputMoney, int itemPrice)
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
                    Console.WriteLine($"${el.Key}: {el.Value} piece ");
                    //get += Convert.ToInt32(el.Key) * Convert.ToInt32(el.Value);
                }
            }
            Console.WriteLine(get);
        }
    }
}
