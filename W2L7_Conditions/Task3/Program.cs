using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int number = int.Parse(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive");
            }
            else if(number < 0)
            {
                Console.WriteLine($"The number {number} is negative");
            }
        }
    }
}
