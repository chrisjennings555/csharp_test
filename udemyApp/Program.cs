using System;

namespace udemyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please tell me your name...");
            string username = Console.ReadLine();

            switch (username)
            {
                case "Chris":
                Console.WriteLine("Hello Chris");
                break;
                case "Kate":
                Console.WriteLine("You have your own laptop");
                break;
                default:
                Console.WriteLine("INTRUDER");
                break;
            }

            
        }
    }
}
