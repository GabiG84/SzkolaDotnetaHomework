using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, provide your personal details");

            Console.WriteLine("First name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Phone:");
            string phone = Console.ReadLine();

            Console.WriteLine("E-mail:");
            string email = Console.ReadLine();

            Console.WriteLine("Date of birth (dd.mm.yyyy):");
            string typedBirth = Console.ReadLine();
            DateTime birth = DateTime.Parse(typedBirth);

            Console.WriteLine("Age:");
            string typedAge = Console.ReadLine();
            int age = int.Parse(typedAge);

            Console.WriteLine("Gender (M or F):");
            string typedGender = Console.ReadLine();
            char gender = char.Parse(typedGender);

            Console.WriteLine("Height (cm):");
            string typedHeight = Console.ReadLine();
            int height = int.Parse(typedHeight);

            Console.WriteLine("Weight (kg):");
            string typedWeight = Console.ReadLine();
            double weight = double.Parse(typedWeight);

            Console.WriteLine("Number of children:");
            string typedChildren = Console.ReadLine();
            int children = int.Parse(typedChildren);

            Console.WriteLine("Years of professional experience:");
            string typedExperience = Console.ReadLine();
            float experience = float.Parse(typedExperience);

            Console.WriteLine("");

            Console.WriteLine("Your personal details:");
            Console.WriteLine($"First name: {firstName}");
            Console.WriteLine($"Last name: {lastName}");
            Console.WriteLine($"Phone: {phone}");
            Console.WriteLine($"E-mail: {email}");
            Console.WriteLine($"Date of birth: {birth}");
            Console.WriteLine($"Age: {age} years old");
            Console.WriteLine($"Gender: {gender}");
            Console.WriteLine($"Height: {height} cm");
            Console.WriteLine($"Weight : {weight} kg");
            Console.WriteLine($"Children: {children}");
            Console.WriteLine($"Experience: {experience} years");
        }
    }
}
