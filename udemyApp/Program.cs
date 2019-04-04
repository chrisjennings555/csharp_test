using System;

namespace udemyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Chris", 30, "Legend");

            Console.WriteLine(person1.getName());
            Console.WriteLine(person1.getAge());
            Console.WriteLine(person1.getNickname());
        }
    }
}
