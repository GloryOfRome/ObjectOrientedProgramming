using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            int health = 100;

            List<Monster> monsters = new List<Monster>()
            {
                new Monster("Monster1", 120, 120, health),
                new Monster("Monster2", 130, 130, health),
                new Monster("Monster3", 140, 140, health),
                new Monster("Monster4", 150, 150, health),
                new Monster("Monster5", 160, 160, health)
            };

            List<Weapon> weapons = new List<Weapon>()
            {
                new Weapon("Weapon1", 20),
                new Weapon("Weapon2", 40),
                new Weapon("Weapon3", 60),
                new Weapon("Weapon4", 80),
                new Weapon("Weapon5", 100)
            };

            List<Armor> armors = new List<Armor>()
            {
                new Armor("Armor1", 10),
                new Armor("Armor2", 30),
                new Armor("Armor3", 50),
                new Armor("Armor4", 70),
                new Armor("Armor5", 90)
            };
            game.FillMonstersList(monsters);
            game.Start(weapons, armors, 100, 100, health);
        }
    }
}
