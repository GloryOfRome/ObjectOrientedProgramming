using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128_Project
{
    class Monster
    {
        public string Name { get; set; }
        public int Strength { get; set; }//基础力量
        public int Defense { get; set; }//基础防御
        public int OriginalHealth { get; set; }//原始健康（生命值）
        public int CurrentHealth { get; set; }//当前健康

        public Monster(string name, int strength, int defense, int originalHealth)
        {
            this.Name = name;
            this.Strength = strength;
            this.Defense = defense;
            this.OriginalHealth = originalHealth;
        }
    }
}
