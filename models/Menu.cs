using System;
using System.Collections.Generic;

namespace models
{
    public class Menu
    {
        List<Hive> HiveList;

        public Menu()
        {
            this.HiveList = new List<Hive>();
        }

        public void Start()
        {
            Console.WriteLine("WELCOME TO BEE KEEPER\n");
            Console.Write("Please name your first hive:");
            CreateNewHive();
        }

        public void MenuScreen()
        {
            Console.WriteLine();
            Console.WriteLine("1. Create new Hive");
            Console.WriteLine("2. Collect Honey");
            Console.WriteLine("3. Report on Bees");
            string userSelect = Console.ReadLine();

            switch (userSelect)
            {
                case "1":
                    CreateNewHive();
                    break;
                case "2":
                    RunCollectHoney();
                    break;
                case "3":
                    ReportBeeCount();
                    break;
                default:
                    Console.WriteLine("That is not a valid option");
                    MenuScreen();
                    break;
            }
        }

        public void CreateNewHive()
        {
            Hive newHive = new Hive();

            Console.WriteLine();
            Console.WriteLine("Name your new Hive: ");
            string hiveName = Console.ReadLine();
            newHive.Name = hiveName;

            this.HiveList.Add(newHive);

            MenuScreen();
        }

        public void RunCollectHoney()
        {
            Console.WriteLine();
            foreach (Hive hive in HiveList)
            {
                Console.WriteLine(hive.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Which Hive would you like to collect from?");
            string hiveSelect = Console.ReadLine();

            for (int i = 0; i < HiveList.Count; i++)
            {
                if (HiveList[i].Name == hiveSelect)
                {
                    Console.WriteLine("How many days would you like to collect?");
                    string daysSelect = Console.ReadLine();

                    if (IsValid(daysSelect) == true)
                    {
                        double daysDouble = double.Parse(daysSelect);
                        HiveList[i].CollectHoney(daysDouble);
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number of days");
                        RunCollectHoney();
                    }
                }
                else
                {
                    Console.WriteLine("That hive doesn't exist. Choose one from the list");
                    RunCollectHoney();
                }
            }

            MenuScreen();
        }

        public void ReportBeeCount()
        {
            Console.WriteLine();
            foreach (Hive hive in HiveList)
            {
                Console.WriteLine(hive.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Which Hive would you like to collect from?");
            string hiveSelect = Console.ReadLine();

            for (int i = 0; i < HiveList.Count; i++)
            {
                if (HiveList[i].Name == hiveSelect)
                {
                    Console.WriteLine($"This Hive contains {HiveList[i].BeeList.Count} bees");
                }
                else
                {
                    Console.WriteLine("That hive doesn't exist. Choose one from the list");
                    ReportBeeCount();
                }
            }

            MenuScreen();
        }

        public bool IsValid(string input)
        {
            double number;

            if (double.TryParse(input, out number))
            {
                if (number < 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}