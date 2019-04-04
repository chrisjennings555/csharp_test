using System;
using System.Collections.Generic;

namespace helloApp
{
    class Program
    {
        private String player;
        private string[] playerList;
         public Program(String player, string[] playerList)
         {
             this.player = player;
             this.playerList = playerList;
         }

        public void addToPlayerList(String player)
        {
            playerList.Add(player);
        }
        static void Main(string[] args)
        {
            List<Object> footballers = new List<Object>();

            footballers.Add("Mesut Ozil");
            footballers.Add("Denis Bergkamp");
            footballers.Add("Jens Lehmann");

            foreach(Object player in footballers)
            {
                Console.WriteLine(player);
            }

            Console.WriteLine("Hello World!");
            Console.WriteLine($"The current time is {DateTime.Now}");
        }
    }
}
