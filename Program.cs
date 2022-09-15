using System;

namespace printMyName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printMyName(Environment.MachineName.ToString());
        }
        static void printMyName(string myName)
        {
            Console.WriteLine("My name is " + myName);
            Console.ReadLine();
        }
    }
}
