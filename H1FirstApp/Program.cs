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

            Players = RugbyPlayers.AddRugbyPlayers();
            Tools.PrintArray(Players);
        }
    }
}