using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age to see what position you can apply for");
            int age = int.Parse(Console.ReadLine());

            if(age >= 21 && age < 30)
            {
                Console.WriteLine("You can be an MP or a prime minister");
            }
            else if(age >= 30 && age < 35)
            {
                Console.WriteLine("You can be an MP, prime minister or senator");
            }
            else if (age >= 35)
            {
                Console.WriteLine("You can be an MP, prime minister, senator or president");
            }
            else
            {
                Console.WriteLine("No job found for your age");
            }
        }
    }
}
