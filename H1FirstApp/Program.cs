// See https://aka.ms/new-console-template for more information

namespace H1FirstApp
{
    class Program
    {
        static string[] Players = new string[5];
        static void Main(string[] args)
        {
            
            //Skating.AdSkatingStuff();
            //Skating.PrintArray();

            //Creating Array with Rugby Players
            Players = RugbyPlayers.AddRugbyPlayers();
            //Printing them out
            Tools.PrintArray(Players);
        }
    }
}