using System;

namespace udemyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please tell me your name...");
            string input = Console.ReadLine();

            if (input.Equals("Chris"))
            {
                Console.WriteLine("Hello Chris");
            }
            else if (input.Equals("Kate"))
            {
                Console.WriteLine("Stop using my laptop");
            }
            else
            {
                Console.WriteLine("OMG intruder alert");
            }
        }
    }
}
