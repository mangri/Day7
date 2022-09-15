using System;

namespace SpacesInString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = askingForInput("Compose and enter any sentence");
            Console.WriteLine("Your sentence had {0} space(s)", numberOfSpaces(userInput));
            Console.ReadLine();
        }
        static string askingForInput(string ask)
        {
            Console.WriteLine(ask);
            return Console.ReadLine();
        }
        static int numberOfSpaces(string userInput)
        {
            int spaces = 0;
            foreach (char s in userInput)
            {
                if (s == ' ') spaces++;
            }
            return spaces;
        }
    }
}

