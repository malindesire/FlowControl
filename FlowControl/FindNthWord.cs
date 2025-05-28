using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowControl
{
    internal class FindNthWord
    {
        public static void FindWord(int nth)
        {
            Console.Write($"Enter a sentence with a minimum of {nth} words: ");
            string input = Console.ReadLine() ?? string.Empty;


            string[] words = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            if (nth > words.Length)
            {
                Console.WriteLine($"There are only {words.Length} words in the sentence.");
                FindWord(nth); // Prompt again for input
            }
            else
            {
                Console.WriteLine($"Nord number {nth} is: '{words[nth - 1]}'");
            }
        }
    }
}
