using System;

namespace udemyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string someText = "first";
            string otherText = "second";
            string formattedText = string.Format("{0} {1} third", someText, otherText);

            Console.WriteLine(formattedText);
        }
    }
}
