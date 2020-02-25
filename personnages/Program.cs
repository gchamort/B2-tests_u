using System;
using System.Threading;

using champi.Classes;
using champi.Exceptions;
using champi.Interfaces;

namespace champi
{
    class Program
    {
        static void Main()
        {
            //invite a la class de perso
            Console.WriteLine("Bienvenu ami cueilleur\n");

            Random rand = new Random();

            //loop tant que la class n'est pas valide
            Picker jo = new Picker(rand.Next(10, 15));
            Console.WriteLine("*Commence la balade* j'ai un sac pour " + jo.GetBagCapacity() + " kilos");

            IMushroom mush = null;

            while (DateTime.Today>DateTime.Today.AddDays(-1))
            {
                switch (rand.Next(1, 4))
                {
                    case 1:
                        mush = new Amanite();
                        break;
                    case 2:
                        mush = new Bolet();
                        break;
                    case 3:
                        mush = new Chanterelle();
                        break;
                }

                Console.WriteLine("\nOh! " + mush.GetName() + " en vue ! le ramasse-je ?\n");

                Console.WriteLine("Taper :\n" +
                    "p - prendre le champi\n" +
                    "t - jeter un champi\n" +
                    "e - échanger avec le dernier champi\n" +
                    "r - je vais plutôt jetter un coup d'oeil au sac\n" +
                    "q - pour quitter la forêt");

                try
                {
                    switch (Console.ReadLine())
                    {
                        case "p":
                            jo.AddItem(mush);
                            break;

                        case "t":
                            jo.PopItem();
                            break;

                        case "e":
                            jo.PopItem();
                            jo.AddItem(mush);
                            break;

                        case "r":
                            jo.PeekBag();
                            break;

                        case "q":
                            Console.WriteLine("retour à la maison.");
                            Thread.Sleep(1500);
                            return;

                        default:
                            Console.WriteLine("Hein?!");
                            break;
                    }
                }
                // remontée des exceptions
                catch (EBagIsFull)
                {
                    // si même en échangeant ça passe pas
                    if (jo.GetBagCapacity() - jo.GetLastMushWeight() + mush.GetWeight() > jo.GetBagCapacity())
                    {
                        Console.WriteLine("peu pô\n");
                        Thread.Sleep(500);
                        Console.WriteLine("Je rentre.");
                        Thread.Sleep(1000);
                        return;
                    }
                    Console.WriteLine("Est-ce qu'on jette un champi ? (o/n)");
                    switch (Console.ReadLine())
                    {
                        case "o":
                        case "O":
                            jo.PopItem();
                            jo.AddItem(mush);
                            break;

                        case "n":
                        case "N":
                            break;
                    }
                }
                catch(EBagIsEmpty)
                {
                    Console.WriteLine("¯\\_(ツ)_/¯");
                }
                if (jo.GetBagCapacity() == jo.GetBagWeight())
                {
                    Console.WriteLine("*gagné ! le sac est plein, retour à la maison.");
                    Console.ReadKey();
                    return;
                }
                Thread.Sleep(500);
                Console.WriteLine("*petits pas petits pas* ...");
                Thread.Sleep(1000);
            }
        }
    }
}
