using System;
using System.Collections.Generic;

namespace models
{
    public class Hive
    {
        public string Name;
        public List<Bee> BeeList;
        public int MaxBees;

        public Hive()
        {
            this.Name = "New Hive";
            this.MaxBees = 6;
            this.BeeList = new List<Bee>();
        }

        public void AddBeeToHive(Bee newBee)
        {
            if (this.BeeList.Count == this.MaxBees)
            {
                Console.WriteLine("This hive is full. Expand your hive to add more bees.");
            }
            else
            {
                this.BeeList.Add(newBee);
            }
        }

        public void CollectHoney(double days)
        {
            double honeyAmount = 0;

            if (this.BeeList.Count == 0)
            {
                Console.WriteLine("This hive is empty. Add bees to start collecting honey");
            }
            else
            {
                for (int i = 0; i < BeeList.Count; i++)
                {
                    honeyAmount = days * this.BeeList[i].Size * 0.2;
                }
            }
        }
    }
}