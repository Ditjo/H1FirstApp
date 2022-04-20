using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1FirstApp
{
    internal class Tools
    {
        private static int counter;

        //static string[] Players = new string[5];
        internal static void PrintArray(string[] Players)
        {
            foreach (var item in Players)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            for (int i = 0; i < Players.Length; i++)
            {
                Console.WriteLine(Players[i] + " " + i);
            }
            Console.WriteLine("");

            while (counter < Players.Length)
            {
                Console.WriteLine(Players[counter]);
                counter++;
            }
            Console.WriteLine("");
        }
    }
}
