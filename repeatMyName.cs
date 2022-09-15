using System;

namespace repeatMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int howMany;
            Console.WriteLine("How many times to repeat my name?");
            bool goodToGo = int.TryParse(Console.ReadLine(), out howMany);
            if(goodToGo && howMany > 0)
            {
                printMyName(Environment.MachineName.ToString(), howMany);
            }
            
        }
        static void printMyName(string myName, int HowMany)
        {
            Console.WriteLine("My name is");
            
            for (int i = 0; i < HowMany; i++)
            {
                Console.WriteLine(myName);
            }

            Console.ReadLine();
        }
    }
}
