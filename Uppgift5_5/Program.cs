using System;
namespace Uppgift5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Slump = new Random();

            string[] SlumpSvar = new string[10];
            string Loop = "";

            SlumpSvar[0] = "1";
            SlumpSvar[1] = "2";
            SlumpSvar[2] = "3";
            SlumpSvar[3] = "4";
            SlumpSvar[4] = "5";
            SlumpSvar[5] = "6";
            SlumpSvar[6] = "7";
            SlumpSvar[7] = "8";
            SlumpSvar[8] = "9";
            SlumpSvar[9] = "10";


            while (Loop != "a")
            {
                Console.WriteLine("Vad är den fråga");
                Loop = Console.ReadLine();
                Console.WriteLine(SlumpSvar[Slump.Next(1, 11) - 1]);
                Console.WriteLine("Vill du fråga et mer till?. skriv a för att avsluta ");
                Loop = Console.ReadLine();

            }
        }
    }
}