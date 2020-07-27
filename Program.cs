using System;
using System.Collections.Generic;

namespace models
{
    class Program
    {
        static void Main(string[] args)
        {
            Bee beeJohn = new Bee("John", 3.2);
            Bee beePaul = new Bee("Paul", 2.7);
            Bee beeGeorge = new Bee("George", 1.1);
            Bee beeRingo = new Bee("Ringo", 2.0);
            Bee beeKurt = new Bee("Kurt", 2.3);
            Bee beeDave = new Bee("Dave", 7.4);
            Bee beeKrist = new Bee("Krist", 1.5);

            Menu menu = new Menu();

            menu.Start();
        }
    }
}
