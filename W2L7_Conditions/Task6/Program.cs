using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height in centimeters:");
            int height = int.Parse(Console.ReadLine());

            if (height < 150)
            {
                Console.WriteLine("Small is beautiful :)");
            }
            else if (height >= 150 && height < 180)
            {
                Console.WriteLine("Your height is normal");
            }
            else if (height >= 180 && height < 240)
            {
                Console.WriteLine("You're really tall");
            }
            else
            {
                Console.WriteLine("Wow, you are a giant!");
            }
        }
    }
}
