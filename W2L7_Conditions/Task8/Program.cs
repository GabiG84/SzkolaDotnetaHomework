using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your math exam result:");
            int.TryParse(Console.ReadLine(), out int maths);

            Console.WriteLine("Enter your physics exam result:");
            int.TryParse(Console.ReadLine(), out int physics);

            Console.WriteLine("Enter your chemistry exam result:");
            int.TryParse(Console.ReadLine(), out int chemistry);

            int totalScore = maths + physics + chemistry;
            bool minimumScore = (maths > 70 && physics > 55 && chemistry > 45) && totalScore > 180;

            if (minimumScore || (maths + physics > 150 || maths + chemistry > 150))
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else
            {
                Console.WriteLine("The result is insufficient");
            }
        }
    }
}
