using System;

namespace sumArrayElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Generation of a random int[] array
            Random rnd = new Random();
            int[] intArray = new int[rnd.Next(10, 50)];
            Console.WriteLine("Array elements: ");
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(0, 10);
                Console.Write(intArray[i] + " ");
            }
            Console.WriteLine();
            (int sum, int arrayLength) = sumArrayElements(intArray);
            Console.WriteLine("The sum of {0} randomly assigned array elements is {1}", arrayLength, sum);
            Console.ReadLine();

        }
        static (int, int) sumArrayElements(int[] intArray)
        {
            int sum = 0;
            for(int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }
            return (sum, intArray.Length);
        }
    }
}
