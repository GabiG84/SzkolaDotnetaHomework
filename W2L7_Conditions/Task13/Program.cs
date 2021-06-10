using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers:");

            double.TryParse(Console.ReadLine(), out double numberOne);
            double.TryParse(Console.ReadLine(), out double numberTwo);

            Console.WriteLine("Enter the number of the operation to be performed:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");

            int.TryParse(Console.ReadLine(), out int choice);

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"Your result is: {numberOne + numberTwo}");
                    break;
                case 2:
                    Console.WriteLine($"Your result is: {numberOne - numberOne}");
                    break;
                case 3:
                    Console.WriteLine($"Your result is: {numberOne * numberOne}");
                    break;
                case 4:
                    Console.WriteLine($"Your result is: {numberOne / numberOne}");
                    break;
                default:
                    Console.WriteLine("Invalid selection");
                    break;
            }
        }
    }
}
