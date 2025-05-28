namespace FlowControl
{
    internal class MovieMenu
    {
        public static void ShowMenu()
        {
            do
            {
                Console.WriteLine("Movie price menu:");
                Console.WriteLine("1. Show single price");
                Console.WriteLine("2. Show total price");
                Console.WriteLine("0. Go back to the main menu");
                Console.Write("Please select an option: ");

                string choice = Console.ReadLine() ?? string.Empty;
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("You selected \"Show single price\"");
                        SinglePrice.ShowSinglePrice();
                        break;
                    case "2":
                        Console.WriteLine("You selected \"Show total price\"");
                        TotalPrice.ShowTotalPrice();
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
