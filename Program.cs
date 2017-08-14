using System;

namespace mathOperations_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double operand1 = double.Parse(Console.ReadLine());
            double operand2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of {operand1} and {operand2} is {operand1 + operand2}");
            Console.WriteLine($"The difference of {operand1} and {operand2} is {operand1 - operand2}");
            Console.WriteLine($"The product of {operand1} and {operand2} is {operand1 * operand2}");
            Console.WriteLine($"The quotient of {operand1} and {operand2} is {operand1 / operand2}");
            Console.WriteLine($"The remainder of {operand1} and {operand2} is {operand1 % operand2}");
        }
    } 
}
