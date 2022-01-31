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
        public int Strength { get; set; }//基础力量
        public int Defense { get; set; }//基础防御
        public int OriginalHealth { get; set; }//原始健康（生命值）
        public int CurrentHealth { get; set; }//当前健康
        public int Coins { get; set; }//硬币
        public Weapon EquippedWeapon { get; set; }//装备武器
        public Armor EquippedArmor { get; set; }//装备盔甲
        public List<Weapon> WeaponsBag { get; set; }//武器包
        public List<Armor> ArmorsBag { get; set; }//盔甲包
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

        public void ShowStats()//显示数据
        {
            Console.WriteLine($"The hero {Name}, get Coins {Coins} pie");
            Console.WriteLine("Press enter to return to main menu.");
            Console.ReadLine();
        }

        public void ShowInventory()//显示库存
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

        public void EquipWeapon()//装备武器
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
