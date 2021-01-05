using System;

namespace VariablesCS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");

            var numberOfCupsOfCoffee = 0;
            var fullName = "Steven Zambito";
            var today = "January 5th, 2021";

            Console.WriteLine(numberOfCupsOfCoffee);
            Console.WriteLine(fullName);
            Console.WriteLine(today);

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            Console.WriteLine($"Nice to meet you {userName}!");

            Console.WriteLine("Please input a number here:");
            var firstNumberAsString = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input another number here:");
            var secondNumberAsString = int.Parse(Console.ReadLine());



        }
    }
}
