using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128_Project
{
    class Hero
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int OriginalHealth { get; set; }
        public int CurrentHealth { get; set; }
        public int Coins { get; set; }
        public Weapon EquippedWeapon { get; set; }
        public Armor EquippedArmor { get; set; }
        public List<Weapon> WeaponsBag { get; set; }
        public List<Armor> ArmorsBag { get; set; }
        public List<Fight> RandomMonsterFights { get; set; }
        public List<Fight> StrongestMonsterFights { get; set; }

        public Hero(string name, int strength, int defense, int originalHealth)
        {
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
            this.OriginalHealth = originalHealth;
            this.WeaponsBag = new List<Weapon>();
            this.ArmorsBag = new List<Armor>();
            this.RandomMonsterFights = new List<Fight>();
            this.StrongestMonsterFights = new List<Fight>();
        }

        public void ShowStats()
        {
            Console.WriteLine($"The hero {Name}, get Coins {Coins} pie");
            Console.WriteLine("Press enter to return to main menu.");
            Console.ReadLine();
        }

        public void ShowInventory()
        {
            Console.WriteLine($"Inventory of hero {Name}:");
            Console.WriteLine("Weapons:");
            foreach (var weapon in WeaponsBag)
            {
                Console.WriteLine($"Name: {weapon.Name}, Power: {weapon.Power}");
            }
            Console.WriteLine("Armors:");
            foreach (var armor in ArmorsBag)
            {
                Console.WriteLine($"Name: {armor.Name}, Power: {armor.Power}");
            }
            Console.WriteLine("Press enter to return to main menu.");
            Console.ReadLine();
        }

        public void EquipWeapon()
        {
            Random r = new Random();
            int randomNum = r.Next(0, WeaponsBag.Count);
            EquippedWeapon = WeaponsBag[randomNum];
        }

        public void EquipArmor()
        {
            Random r = new Random();
            int randomNum = r.Next(0, ArmorsBag.Count);
            EquippedArmor = ArmorsBag[randomNum];
        }

        public int GetNumberOfFightsWon(List<Fight> fights)
        {
            int total = 0;
            foreach (var fight in fights)
            {
                if (fight.Winner == PlayerType.Hero)
                    total++;
            }
            return total;
        }
    }
    
}
