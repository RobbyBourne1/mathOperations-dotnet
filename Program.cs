using System;

namespace mathOperations_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Hello, Please Enter Number 1: ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Hello, Please Enter Number 2: ");
            double operand2 = double.Parse(Console.ReadLine());
            
            var sum = operand1 + operand2;
            var difference = operand1 - operand2;
            var product = operand1 * operand2;
            var quotient = operand1 / operand2;
            var remainder = operand1 % operand2;

            ShowResults(operand1, operand2, sum, difference, product, quotient, remainder);
        }

        public static void ShowResults(double operand1, double operand2, double sum, double difference, double product, double quotient, double remainder)
        {    
            Console.WriteLine($"The sum of {operand1} and {operand2} is {sum}");
            Console.WriteLine($"The difference of {operand1} and {operand2} is {difference}");
            Console.WriteLine($"The product of {operand1} and {operand2} is {product}");
            Console.WriteLine($"The quotient of {operand1} and {operand2} is {quotient}");
            Console.WriteLine($"The remainder of {operand1} and {operand2} is {remainder}");
        }


    } 
}
