using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128_Project
{
    class Armor
    {
        public string Name { get; set; }
        public int Power { get; set; }//力量

        public Armor(string name, int power)
        {
            this.Name = name;
            this.Power = power;
        }
    }
}
