using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOne
{
    class Armor
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Armor(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
