using System;
using System.Collections.Generic;

namespace models
{
    public class Menu
    {
        List<Hive> HiveList;

        public void Start()
        {
            Console.WriteLine("WELCOME TO BEE KEEPER\n");
            Console.Write("Please name your first hive: ");
            string firstHiveName = Console.ReadLine();
            CreateNewHive(firstHiveName);
        }

        public void CreateNewHive(string hiveName)
        {
            Hive newHive = new Hive();
            newHive.Name = hiveName;
        }

        public void RunCollectHoney()
        {

        }

        public void ReportBeeCount()
        {

        }
    }
}