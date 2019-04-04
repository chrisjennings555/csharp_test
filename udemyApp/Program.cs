using System;

namespace udemyApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            InputConverter inputConverter = new InputConverter();
            CalculatorEngine calculatorEngine = new CalculatorEngine();

            Console.WriteLine("Enter a number...");
            double firstNumber = inputConverter.convertInputToNumeric(Console.ReadLine());
            Console.WriteLine("Enter another number...");
            double secondNumber = inputConverter.convertInputToNumeric(Console.ReadLine());
            Console.WriteLine("What do you want to do to the numbers?");
            string operation = Console.ReadLine();

            double result = calculatorEngine.calculate(operation, firstNumber, secondNumber);
            
            Console.WriteLine("The result = " + result);
        }
    }
}
