using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width of the rectangle");
            var typedWidth = Console.ReadLine();
            double.TryParse(typedWidth, out double width);

            Console.WriteLine("Enter the length of the rectangle");
            var typedLength = Console.ReadLine();
            double.TryParse(typedLength, out double length);

            double diagonal = Math.Sqrt(Math.Pow(width, 2) + Math.Pow(length, 2));
            Console.WriteLine($"The diagonal of the rectangle is: {Math.Round(diagonal, 2)}");
        }
    }
}
