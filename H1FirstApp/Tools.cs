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
        //Methodes for printing the array
        internal static void PrintArray(string[] Players)
        {
            //Using foreach to print
            Console.WriteLine("Foreach Loop");
            Console.WriteLine("");
            foreach (var item in Players)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            //Using for to print
            Console.WriteLine("For Loop");
            Console.WriteLine("");
            for (int i = 0; i < Players.Length; i++)
            {
                Console.WriteLine(Players[i] + " " + i);
            }
            Console.WriteLine("");

            //Using while to print
            Console.WriteLine("While Loop");
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
