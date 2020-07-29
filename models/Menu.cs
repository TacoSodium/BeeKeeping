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
                    Start();
                    break;
            }
        }

        public void CreateNewHive()
        {
            Console.WriteLine();
            if (this.HiveList.Count == 2)
            {
                Console.WriteLine("Two Hives is enough for now");
                Start();
            }
            else
            {
                Hive newHive = new Hive();

                Console.WriteLine("Name your new Hive: ");
                string hiveName = Console.ReadLine();
                newHive.Name = hiveName;

                if (this.HiveList.Count == 0)
                {
                    Bee beeJohn = new Bee("John", 3.2);
                    Bee beePaul = new Bee("Paul", 2.7);
                    Bee beeGeorge = new Bee("George", 1.1);
                    Bee beeRingo = new Bee("Ringo", 2.0);

                    newHive.BeeList.Add(beeJohn);
                    newHive.BeeList.Add(beePaul);
                    newHive.BeeList.Add(beeGeorge);
                    newHive.BeeList.Add(beeRingo);
                }
                else
                {
                    Bee beeKurt = new Bee("Kurt", 2.3);
                    Bee beeDave = new Bee("Dave", 7.4);
                    Bee beeKrist = new Bee("Krist", 1.5);

                    newHive.BeeList.Add(beeKurt);
                    newHive.BeeList.Add(beeDave);
                    newHive.BeeList.Add(beeKrist);
                }

                this.HiveList.Add(newHive);
                Start();
            }
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

            Start();
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

            Start();
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