using System;

namespace udemyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "hello";
            int someNumber = 11;
            double anotherNumber = 11.5;
            bool isTrue = true;
            string input = Console.ReadLine();
            int convertInputToNumber;
            int.TryParse(input, out convertInputToNumber);
            int squareInput = convertInputToNumber * convertInputToNumber;
            var anything = 11.6;

            Console.WriteLine(someText);
            Console.WriteLine(someNumber);
            Console.WriteLine(anotherNumber);
            Console.WriteLine(isTrue);
            Console.WriteLine("Inputted number = " + input);
            Console.WriteLine(anything);
            Console.WriteLine(squareInput);
        }
    }
}
