using System;
using System.Threading;

namespace sumFromTo
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Getting the _from element
            int _from;
            string userInputFrom = askingForInput("Enter the first element of 'from + ... + to' array");
            bool goodToGoFrom = int.TryParse(userInputFrom, out _from);
            //Getting the _to element
            int _to;
            string userInputTo = askingForInput("Enter the last element of 'from + ... + to' array");
            bool goodToGoTo = int.TryParse(userInputTo, out _to);
            //Executing sumation if intermediate output required
            if (goodToGoFrom && goodToGoTo && askingForInput("Do you wish to see intermediate output? y/n") == "y")
            {
                sumFromTo(_from, _to, true);
            }
            //Executing sumation if intermediate output is not necessary
            else if (goodToGoFrom && goodToGoTo)
            {
                sumFromTo(_from, _to);
            }

        }
        static string askingForInput(string ask)
        {
            Console.WriteLine(ask);
            return Console.ReadLine();
        }
        static void sumFromTo(int _from, int _to)
        {
            if (_from > 0 && _to > _from)
            {
                int sum = 0;
                for(int i = _from; i <= _to; i++)
                {
                    sum += i;
                }
                Console.WriteLine("The final sum is " + sum);
            }
            else
            {
                Console.WriteLine("Something is wrong with the input");
            }
        }
        static void sumFromTo(int _from, int _to, bool outputTrue)
        {
            if(outputTrue && _from > 0 && _to > _from)
            {
                int sum = 0;
                for (int i = _from; i <= _to; i++)
                {
                    Thread.Sleep(500);
                    Console.Write($"{sum} + {i} = ");
                    sum += i;
                    Console.Write(sum);
                    Console.WriteLine();
                }
                Console.WriteLine("The final sum is " + sum);
            }
            else
            {
                Console.WriteLine("Something is wrong with the input");
            }

        }
    }
}
