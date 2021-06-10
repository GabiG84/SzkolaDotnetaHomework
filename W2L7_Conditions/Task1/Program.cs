using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberA = 5;

            int numberB = 5;

            if(numberA == numberB)
            {
                Console.WriteLine($"{numberA} and {numberB} are equal");
            }
            else
            {
                Console.WriteLine($"{numberA} and {numberB} are not equal");
            }
        }
    }
}
