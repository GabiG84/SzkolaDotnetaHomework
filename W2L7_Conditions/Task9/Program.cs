using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the current temperature:");
            int.TryParse(Console.ReadLine(), out int temp);

            if(temp >= 0)
            {
                if(temp < 10)
                {
                    Console.WriteLine("Zimno");
                }
                else if(temp >= 10 && temp < 20)
                {
                    Console.WriteLine("Chłodno");
                }
                else if(temp >= 20 && temp < 30)
                {
                    Console.WriteLine("W sam raz");
                }
                else if (temp >= 30 && temp < 40)
                {
                    Console.WriteLine("Zaczyna być słabo, bo gorąco");
                }
                else
                {
                    Console.WriteLine("A weź, wyprowadzam się na Alaskę");
                }
            }
            else
            {
                Console.WriteLine("Cholernie piździ");
            }
        }
    }
}
