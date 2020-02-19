using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using personnages.Classes;

namespace personnages
{
    class Program
    {
        static void Main(string[] args)
        {
            //invite a la class de perso
            Console.WriteLine("Select a class by number :\n" +
                "1 - Warrior\n" +
                "2 - Mage\n" +
                "3 - Chaman\n" +
                "4 - Thief\n");

            //loop tant que la class n'est pas valide
            string pclass = null;
            Player player = null;

            while (player == null)
            {
                pclass = Console.ReadLine();
                switch (int.Parse(pclass))
                {
                    case 1:
                        player = new Warrior();
                        break;
                    case 2:
                        player = new Mage();
                        break;
                    case 3:
                        player = new Chaman();
                        break;
                    case 4:
                        player = new Thief();
                        break;
                    default:
                        Console.WriteLine("Not a valid class");
                        break;
                }
            }

            try
            {
                // boucle d'action
                TheLoop(player);
            }
            catch (Exception ex)
            {
                // remontée des exceptions
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }

            Console.WriteLine("Bye.");
            Thread.Sleep(2500);
        }

        static void TheLoop(Player player)
        {
            bool loop = true;
            string action = null;

            while (loop)
            {
                //invite a l'action
                Console.WriteLine("Select an action by typing :\n" +
                    "add - to add an item\n" +
                    "pop - to remove an item\n" +
                    "num - count item in bag\n" +
                    "exit - to stop\n");
                action = Console.ReadLine();

                switch (action)
                {
                    case "add":
                        player.AddItem();
                        break;

                    case "pop":
                        player.PopItem();
                        break;

                    case "num":
                        player.WeightBag();
                        break;

                    case "exit":
                        loop = false;
                        break;

                    default:
                        Console.WriteLine("Not a valid action");
                        break;

                }
            }
        }
    }
}
