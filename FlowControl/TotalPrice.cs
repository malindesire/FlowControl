namespace FlowControl
{
    internal class TotalPrice
    {
        public static void ShowTotalPrice()
        {
            Console.Write("Enter the number of visitors: ");
            string qty = Console.ReadLine() ?? string.Empty;

            if (int.TryParse(qty, out int numberOfVisitors) && numberOfVisitors > 0)
            {
                int totalPrice = 0;
                for (int i = 0; i < numberOfVisitors; i++)
                {
                    Console.Write($"Enter age for visitor {i + 1}: ");
                    string ageInput = Console.ReadLine() ?? string.Empty;

                    if (int.TryParse(ageInput, out int age))
                    {
                        Visitor visitor = new Visitor(age);
                        totalPrice += visitor.Price;
                    }
                    else
                    {
                        Console.WriteLine("Invalid age input, please try again.");
                        i--; // Decrement to retry this visitor
                    }
                }
                Console.WriteLine($"Total price for these {numberOfVisitors} visitors is: {totalPrice}kr");
            }
            else
            {
                Console.WriteLine("Invalid number of visitors, please try again.");
                ShowTotalPrice(); // Retry if input is invalid
            }

            Console.WriteLine("Press any key to return to the Movie Menu.");
            Console.ReadKey();
            MovieMenu.ShowMenu();
        }
    }
}
