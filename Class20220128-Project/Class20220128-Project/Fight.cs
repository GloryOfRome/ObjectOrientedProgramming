using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128_Project
{
    public enum PlayerType
    {
        Hero,
        Monster
    }

    class Fight
    {
        public Hero Hero { get; set; }
        public Monster Monster { get; set; }
        public PlayerType Winner { get; set; }

        public Fight(Hero hero, Monster monster)
        {
            this.Hero = hero;
            this.Monster = monster;
        }

        public void StartFight()
        {
            Console.WriteLine("Let's Go.");
            Console.WriteLine($"{Hero.Name} is first.");
            Console.WriteLine("Press enter to begin.");
            Console.ReadLine();

            while (Hero.CurrentHealth > 0 && Monster.CurrentHealth > 0)
            {
                HeroTurn();
                if (Monster.CurrentHealth <= 0)
                    break;
                MonsterTurn();
            }
            Console.WriteLine("Press enter to return to main menu.");
            Console.ReadLine();
        }

        public void MonsterTurn()
        {
            Hero.EquipArmor();
            Console.WriteLine($"{Monster.Name}  Turn:");
            Console.WriteLine($"Please press enter, {Monster.Name} will attack {Hero.Name}.");
            Console.ReadLine();


            if (Hero.EquippedArmor.Power + Hero.Defense < Monster.Strength)
            {
                int healthLost = Monster.Strength - (Hero.EquippedArmor.Power + Hero.Defense);
                if (Hero.Coins <= healthLost && Hero.Coins > 0)
                {

                    Console.WriteLine($"Using {Hero.Name}'s {Hero.Coins} coins toward health.");
                    healthLost -= Hero.Coins;
                    Hero.Coins = 0;
                }
                else if (Hero.Coins > healthLost)
                {
                    Console.WriteLine($"Using {healthLost} coins toward health.");
                    Hero.Coins -= healthLost;
                    healthLost = 0;
                }

                Hero.CurrentHealth -= healthLost;
                Console.WriteLine($"{Hero.Name} lost {healthLost} health points.");
                if (Hero.CurrentHealth <= 0)
                {
                    Lose();
                }
            }
            else
            {
                Console.WriteLine($"{Hero.Name} lost no health points.");
            }
        }

        public void HeroTurn()
        {
            Hero.EquipWeapon();
            Console.WriteLine($"{Hero.Name} Turn:");
            Console.WriteLine($"Please press enter, {Hero.Name} will attack {Monster.Name} with {Hero.EquippedWeapon.Name}.");
            Console.ReadLine();

            if (Hero.EquippedWeapon.Power + Hero.Strength > Monster.Defense)
            {
                int healthLost = Hero.EquippedWeapon.Power + Hero.Strength - Monster.Defense;

                Monster.CurrentHealth -= healthLost;
                Console.WriteLine($"{Monster.Name} lost {healthLost} health points.");
                if (Monster.CurrentHealth <= 0)
                {
                    Win();
                }

            }
            else
            {

            }

        }

        public void Win()
        {
            Winner = PlayerType.Hero;
            Hero.Coins += 20;
            Console.WriteLine($"You Won! And get 20 coins!");
        }

        public void Lose()
        {
            Winner = PlayerType.Monster;
            Console.WriteLine($"You Lost");
        }
    }
}
