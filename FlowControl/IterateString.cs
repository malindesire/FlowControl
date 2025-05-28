namespace FlowControl
{
    internal class IterateString
    {
        public static void Run()
        {
            Console.Write("Enter a string that will be iterated 10 times: ");
            string input = Console.ReadLine() ?? string.Empty;

            string text = string.Empty;
            
            for (int i = 0; i < 10; i++)
            {   
                string ending = i == 9 ? "." : ", ";
                text += $"{i + 1}. {input}{ending}";
            }

            Console.WriteLine(text);
        }
    }
}
