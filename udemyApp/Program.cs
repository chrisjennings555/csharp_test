using System;

namespace udemyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();

                try
                {
                    StringToIntConverter stringToIntConverter = new StringToIntConverter();
                    stringToIntConverter.convert(input);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("There was an error with conversion: {0}", ex.Message);
                }
            }
        }
    }
}
