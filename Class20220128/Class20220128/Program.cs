using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128
{
    class Program
    {
        static void Main(string[] args)
        {
            Category furniture = new Category() { Id = 1, Name = "Furniture" };
            Product officeChair = new Product() {Name= "office Chair" ,Price=400,
                Stock =20,CategoryId=1,Category= furniture};
            Console.WriteLine(officeChair);
        }
    }
}
