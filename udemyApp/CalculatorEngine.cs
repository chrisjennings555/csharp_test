using System;

namespace udemyApp
{
    public class CalculatorEngine
    {
        public double calculate(string operation, double num1, double num2)
        {
            double result;

            switch(operation.ToLower())
            {
                case "add":
                case "+":
                    result = num1 + num2;
                    break;
                case "subtract":
                case "-":
                    result = num1 - num2;
                    break;
                case "multiply":
                case "*":
                    result = num1 * num2;
                    break;
                case "divide":
                case "/":
                    result = num1 / num2;
                    break;
                default:
                    throw new InvalidOperationException("Specified operator does not exist");
            }
            return result;
        }
    }
}