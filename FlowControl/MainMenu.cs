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
                Console.WriteLine("1. Show movie prices");
                Console.WriteLine("2. Iterate string x10");
                Console.WriteLine("3. Find the third word");
                Console.WriteLine("0. Exit");
                Console.Write("Please select an option: ");

                string choice = Console.ReadLine() ?? string.Empty;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You selected \"Show movie prices\"");
                        MovieMenu.ShowMenu();
                        break;
                    case "2":
                        Console.WriteLine("You selected \"Iterate string x10\"");
                        IterateString.Run();
                        break;
                    case "3":
                        Console.WriteLine("You selected \"Find the third word\"");
                        FindNthWord.FindWord(3);
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
