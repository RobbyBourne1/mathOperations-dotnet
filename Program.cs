using System;

namespace mathOperations_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {num1} and {num2} is {num1 + num2}");
            Console.WriteLine($"The difference of {num1} and {num2} is {num1 - num2}");
            Console.WriteLine($"The product of {num1} and {num2} is {num1 * num2}");
            Console.WriteLine($"The quotient of {num1} and {num2} is {num1 / num2}");
            Console.WriteLine($"The remainder of {num1} and {num2} is {num1 % num2}");
        }
    } 
}
