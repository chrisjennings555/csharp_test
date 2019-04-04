using System;

namespace udemyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please tell me your name...");
            string input = Console.ReadLine();

            switch (input)
            {
                case "Chris":
                Console.WriteLine("Hello Chris");
                break;
                case "Kate":
                Console.WriteLine("You have your own laptop");
                break;
                default:
                Console.WriteLine("Hello Chris");
                break;
            }

            
        }
    }
}
