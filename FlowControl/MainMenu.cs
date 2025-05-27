using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class MainMenu
    {
        public static void ShowMenu()
        {
            do {
                Console.WriteLine("Main Menu:");
                Console.WriteLine("1. Movie Prices");
                Console.WriteLine("2. Iterate x10");
                Console.WriteLine("3. Get third word");
                Console.WriteLine("0. Exit");
                Console.Write("Please select an option: ");

                string choice = Console.ReadLine() ?? string.Empty;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You selected Movie Prices");
                        break;
                    case "2":
                        Console.WriteLine("You selected Iterate x10.");
                        break;
                    case "3":
                        Console.WriteLine("You selected Get Third Word");
                        break;
                    case "0":
                        Console.WriteLine("Exiting the program.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid selection, please try again.");
                        ShowMenu();
                        break;
                }
            } while (true);

        }
    }
}
