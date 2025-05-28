namespace FlowControl
{
    internal class SinglePrice
    {
        public static void ShowSinglePrice()
        {
            Console.Write("Enter age of visitor: ");
            string input = Console.ReadLine() ?? string.Empty;
            
            if (int.TryParse(input, out int age))
            {
                Visitor visitor = new Visitor(age);
                Console.WriteLine($"The price for age {visitor.Age} is: {visitor.Price}kr");

                Console.WriteLine("Press any key to return to the movie price menu...");
                Console.ReadKey();
                MovieMenu.ShowMenu();
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                ShowSinglePrice();
            }

        }
    }
}
