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
            var today = new DateTime();

            Console.WriteLine(numberOfCupsOfCoffee);
            Console.WriteLine(fullName);
            Console.WriteLine(today);

            Console.WriteLine(" ");

            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            if (userName == "Alice")
            {
                Console.WriteLine("Hello Alice!");
            }
            else
            {
                Console.WriteLine($"Nice to meet you {userName}!");
            }

            Console.WriteLine(" ");

            Console.WriteLine("Please input a number here:");
            var firstNumberAsString = Console.ReadLine();
            Console.WriteLine("Please input another number here:");
            var secondNumberAsString = Console.ReadLine();

            var firstOperand = double.Parse(firstNumberAsString);
            var secondOperand = double.Parse(secondNumberAsString);

            var sum = firstOperand + secondOperand;
            var difference = (firstOperand - secondOperand);
            var product = (firstOperand * secondOperand);
            var quotient = (firstOperand / secondOperand);
            var remainder = (firstOperand % secondOperand);

            Console.WriteLine(" ");
            Console.WriteLine($"If you add {firstNumberAsString} and {secondNumberAsString}, you get {sum}. {firstOperand} minus {secondOperand} is {difference}. {firstOperand} divided by {secondOperand} is {quotient}. The product of {firstOperand} and {secondOperand} is {product}. The remainder of {firstOperand} divided by {secondOperand} is {remainder}.");
        }
    }
}
