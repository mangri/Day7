using System;

namespace bodyMassIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight;
            bool goodWeight = double.TryParse(askingForInput("Enter your weight in [kg]"), out weight);
            double height;
            bool goodHeight = double.TryParse(askingForInput("Enter your height in [m]"), out height);
            if(goodWeight && goodHeight)
            {
                Console.WriteLine("Body mass index = {0:0.00}", bodyMassIndex(weight, height));
            }
            Console.ReadLine();

        }
        static string askingForInput(string ask)
        {
            Console.WriteLine(ask);
            return Console.ReadLine();
        }
        static double bodyMassIndex(double weight, double height)
        {
            return weight / Math.Pow(height, 2);
        }
    }
}
