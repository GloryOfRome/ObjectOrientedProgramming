using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Armor
    {
        public static List<string> Armors = new List<string>
    {
      "Soul Booster",
      "Hurricane Pike",
      "Blade Mail",
      "Crimson Guard",
      "Assault Cuirass",
      "Vauguard",
      "Aeon Disk",
      "Lotus Orb",
      "Manta Style",
      "Bloodstoon",
    };
        public string Name { get; set; }
        public int Power { get; set; }
        public Armor(string name)
        {
            Name = name;
            Power = new Random().Next(1, 3);
        }
    }
}
