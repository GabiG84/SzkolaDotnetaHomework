using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number");
            int number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd");
            }
        }
    }
}
