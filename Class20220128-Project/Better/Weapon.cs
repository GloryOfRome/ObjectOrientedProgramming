using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better
{
    class Weapon
    {
        public string Name { get; set; }
        public int Power { get; set; }

        public Weapon(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
