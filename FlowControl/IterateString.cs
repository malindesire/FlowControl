namespace FlowControl
{
    internal class IterateString
    {
        public static void Iterate(int qty)
        {
            Console.Write($"Enter a string that will be iterated {qty} times: ");
            string input = Console.ReadLine() ?? string.Empty;

            string text = string.Empty;
            
            for (int i = 0; i < qty; i++)
            {   
                string ending = i + 1 == qty ? "." : ", ";
                text += $"{i + 1}. {input}{ending}";
            }

            Console.WriteLine(text);

            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey(); 
            MainMenu.ShowMenu(); // Return to main menu after displaying the string
        }
    }
}
