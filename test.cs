using System;

namespace TestNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Advanced Program!");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Calculator calculator = new Calculator();
                int result = calculator.Square(number);

                Console.WriteLine($"Hello, {name}! The square of {number} is {result}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }

    class Calculator
    {
        public int Square(int number)
        {
            return number * number;
        }
    }
}