using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220125
{
    class Car
    {
        public string Name;
        public string Colour;
        public string Nationality;//生产国家
        public DateTime ProductionDate;//生产日期                                                   
        public int Number;//数量

        public Car() { }
        public Car(string name, string colour, string nationality,  int number)
        {
            this.Name = name;
            this.Colour = colour;
            this.Nationality = nationality;
            this.Number = number;
        }
    }
}
