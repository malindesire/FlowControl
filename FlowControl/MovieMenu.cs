using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class MovieMenu
    {
        public static void ShowMenu()
        {
            do
            {
                Console.WriteLine("Movie Menu:");
                Console.WriteLine("1. Get Single Price");
                Console.WriteLine("2. Get Total Price");
                Console.WriteLine("0. Go to Main Menu");
                Console.Write("Please select an option: ");

                string choice = Console.ReadLine() ?? string.Empty;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You selected Single Price");
                        break;
                    case "2":
                        Console.WriteLine("You selected Total Price");
                        break;
                    case "0":
                        Console.WriteLine("Going back to Main Menu");
                        MainMenu.ShowMenu();
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
