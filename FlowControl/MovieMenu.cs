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
                        Console.WriteLine("You selected Get Single Price");
                        SinglePrice.ShowSinglePrice();
                        break;
                    case "2":
                        Console.WriteLine("You selected Total Price");
                        break;
                    case "0":
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
