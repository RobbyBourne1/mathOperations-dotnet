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
            
            var sum = operand1 + operand2;
            var difference = operand1 - operand2;
            var product = operand1 * operand2;
            var quotient = operand1 / operand2;
            var remainder = operand1 % operand2;

            Console.WriteLine($"The sum of {operand1} and {operand2} is {sum}");
            Console.WriteLine($"The difference of {operand1} and {operand2} is {difference}");
            Console.WriteLine($"The product of {operand1} and {operand2} is {product}");
            Console.WriteLine($"The quotient of {operand1} and {operand2} is {quotient}");
            Console.WriteLine($"The remainder of {operand1} and {operand2} is {remainder}");
        }
    } 
}
