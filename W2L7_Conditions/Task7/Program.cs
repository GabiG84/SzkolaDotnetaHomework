using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter three numbers:");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            if(numberOne > numberTwo)
            {
                if(numberOne > numberThree)
                {
                    Console.WriteLine($"The number {numberOne} is the largest");
                }
                else
                {
                    Console.WriteLine($"The number {numberThree} is the largest");
                }
            }
            else if(numberTwo > numberThree)
            {
                Console.WriteLine($"The number {numberTwo} is the largest");
            }
            else
            {
                Console.WriteLine($"The number {numberThree} is the largest");
            }
        }
    }
}
