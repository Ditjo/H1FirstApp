
namespace H1FirstApp
{
    internal static class Skating
    {
        static string[] skatingStuff = new string[5];
        private static int counter;

        public static void AdSkatingStuff()
        {
            skatingStuff[0] = "Rulleskøjter";
            skatingStuff[1] = "Longboard";
            skatingStuff[2] = "løbehjul";
            skatingStuff[3] = "Skateboard";
            skatingStuff[4] = "Strygebræt";
        }

        internal static void PrintArray()
        {
            foreach (var item in skatingStuff)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < skatingStuff.Length; i++)
            {
                Console.WriteLine(skatingStuff[i] + " " + i);
            }

            while (counter < skatingStuff.Length)
            {
                Console.WriteLine(skatingStuff[counter]);
                counter++;
            }
        }
    }
}
