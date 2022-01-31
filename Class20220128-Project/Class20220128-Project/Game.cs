using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class20220128_Project
{
    public enum MenuType
    {
        Main,//主要的
        Fight//斗争
    }

    class Game
    {
        public string Name { get; set; }
        public Hero Hero { get; set; }
        public Monster CurrentMonster { get; set; }
        public List<Monster> Monsters { get; set; }

        public Game()
        {
            Monsters = new List<Monster>();
        }

        public void Start(List<Weapon> weapons,List<Armor> armors,int heroStrength,int heroDefense,int health)
        {
            string name= GetUsersName();
            Console.WriteLine();

            Hero hero = new Hero(name, heroStrength, heroDefense, health);
            Hero = hero;
            WeaponsInBag(weapons);//装满英雄武器包
            ArmorsInBag(armors);//填充英雄盔甲包

            int selection = GetMenuSelection(MenuType.Main);
            while (selection != 4)
            {
                HandleMainMenuSelection(selection);
                selection = GetMenuSelection(MenuType.Main);
            }
        }

        public void HandleMainMenuSelection(int selection)
        {
            switch (selection)
            {
                case 1:
                    Hero.ShowStats();
                    break;
                case 2:
                    Hero.ShowInventory();
                    break;
                case 3:
                    StartNewFight();
                    break;
                default:
                    break;
            }
        }

        public void StartNewFight()
        {
            int selection = GetMenuSelection(MenuType.Fight);
            bool IsStrongestFight = false;

            switch (selection)
            {
                case 1:
                    RandomCurrentMonster();//设置随机当前怪物
                    break;
                case 2:
                    StrongestMonster(Monsters);
                    IsStrongestFight = true;
                    break;
                default:
                    Console.WriteLine("Invalid Selection.");
                    break;
            }

            Hero.CurrentHealth = Hero.OriginalHealth;
            CurrentMonster.CurrentHealth = CurrentMonster.OriginalHealth;
            Fight newFight = new Fight(Hero, CurrentMonster);

            if (IsStrongestFight)
            {
                Hero.StrongestMonsterFights.Add(newFight);
            }
            else
            {
                Hero.RandomMonsterFights.Add(newFight);
            }

            newFight.StartFight();
        }       

        public void StrongestMonster(List<Monster> monsters)
        {
            Monster strongestMonster = null;
            int strongest = 0;
            foreach (var monster in monsters)
            {
                int totalStrength = monster.Defense + monster.Strength;
                if (totalStrength > strongest)
                {
                    strongest = totalStrength;
                    strongestMonster = monster;
                }
            }
            CurrentMonster = strongestMonster;
        }

        public void RandomCurrentMonster()
        {
            Random r = new Random();
            int randomNum = r.Next(0, Monsters.Count);
            CurrentMonster = Monsters[randomNum];
        }

        public int GetMenuSelection(MenuType menuType)
        {
            HashSet<int> selectionOptions;

            if (menuType == MenuType.Fight)
            {
                ShowFightOptions();
                selectionOptions = new HashSet<int>() { 1, 2 };
            }
            else
            {
                ShowMainMenu();//显示主菜单
                selectionOptions = new HashSet<int>() { 1, 2, 3, 4 };
            }

            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int selection);

            if (!selectionOptions.Contains(selection))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                userInput = Console.ReadLine();
                int.TryParse(userInput, out selection);
            }
            //Console.WriteLine("Thank you");
            Console.WriteLine();
            return selection;
        }

        public void ShowMainMenu()
        {
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Show Statistics");
            Console.WriteLine("2. Show Inventory");
            Console.WriteLine("3. Fight!");
            Console.WriteLine("4. Exit Game");
        }

        public void ShowFightOptions()
        {
            Console.WriteLine("Please choose whom you fight:");
            Console.WriteLine("1. A Random Monster");
            Console.WriteLine("2. A Strongest Monster");
        }

        public void ArmorsInBag(List<Armor> armors)
        {
            foreach (var armor in armors)
            {
                Hero.ArmorsBag.Add(armor);
            }
        }

        public void WeaponsInBag(List<Weapon> weapons)
        {
            foreach (var weapon in weapons)
            {
                Hero.WeaponsBag.Add(weapon);
            }
        }

        public string GetUsersName()
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            if (name == null || name == "")
            {
                Console.WriteLine("The Name is empty,Please enter your name:");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Thank you {name}, Let's start the game!");
            return name;
        }

        public void FillMonstersList(List<Monster> monsters)
        {
            foreach (var monster in monsters)
            {
                Monsters.Add(monster);
            }
        }

        public void FillHeroWeaponsBag(List<Weapon> weapons)
        {
            foreach (var weapon in weapons)
            {
                Hero.WeaponsBag.Add(weapon);
            }
        }

        public void FillHeroArmorsBag(List<Armor> armors)
        {
            foreach (var armor in armors)
            {
                Hero.ArmorsBag.Add(armor);
            }
        }
    }
}
