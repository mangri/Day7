using System;

namespace stringAnalysis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Compose and enter any sentence");
            hashingString(Console.ReadLine());
        }
        static void hashingString(string userImput)
        {
            for(int i = 0; i < userImput.Length; i++)
            {
                Console.Write("#");
            }
            Console.ReadLine();
        }
            
    }
}
