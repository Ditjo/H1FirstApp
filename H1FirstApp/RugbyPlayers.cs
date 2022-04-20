
namespace H1FirstApp
{
    internal static class RugbyPlayers
    {
        //Creating a new Array called Players which can hold 5 "Players"
        static string[] Players = new string[5];

        //Adding Rugby Players into the array.
        public static string[] AddRugbyPlayers()
        {
            Players[0] = "Asafo Aumua";
            Players[1] = "Angus Ta'avao";
            Players[2] = "Tupou Vaa'i";
            Players[3] = "Quinn Tupaea";
            Players[4] = "Richie Mo'unga";

            //Returning array
            return Players;
        }
    }
}
