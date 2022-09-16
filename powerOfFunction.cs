using System;

namespace powerOfFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base member of base^power expression");
            double realBase;
            bool maybeBase = double.TryParse(Console.ReadLine(), out realBase);
            Console.WriteLine("Enter the power member of base^power expression");
            int realPower;
            bool maybePower = int.TryParse(Console.ReadLine(), out realPower);
            if(maybePower && maybeBase)
            {
                double result = powerOfFunction(realBase, realPower);
                Console.WriteLine("The calculated value of {0}^{1} is {2:0.000}", realBase, realPower, result);
            }
        }
        static double powerOfFunction(double realBase, int realPower)
        {
            if (realPower == 0)
            {
                return 1;
            }
            if(realPower > 0)
            {
                realPower--;
                return realBase *= powerOfFunction(realBase, realPower);
            }
            return realBase;
        }
    }
}
