using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dimensions of the three sides of the triangle:");

            int.TryParse(Console.ReadLine(), out int side1);
            int.TryParse(Console.ReadLine(), out int side2);
            int.TryParse(Console.ReadLine(), out int side3);

            if(side1 + side2 > side3 || side1 + side3 > side2 || side2 + side3 > side1)
            {
                Console.WriteLine("You can create a triangle with the given dimensions");
            }
            else
            {
                Console.WriteLine("You can't create a triangle from the given dimensions");
            }
        }
    }
}
