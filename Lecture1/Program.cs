using System;
using System.Globalization;

namespace P2_Simple_Console_Calculator
{
    public class Program
    {
        public static float aFirstValue, aSecondValue;
        public static string aSymbol;

        public static void Main(string[] args)
        {
            Console.WriteLine("Piesiam eglute");
            DrawFirTree("Iveskite eglutes eiluciu kieki (gali buti tik sveikas skaicius, pvz 15)");
        }

        static void DrawFirTree(string aMessage)
        {
            int aLines;
            Console.WriteLine(aMessage);
            string aString = Console.ReadLine();

            if (int.TryParse(aString, out aLines))
            {
                int aStars = 1, aStem = aLines / 3;
                int aTotalSymbols = 1 + (aLines - 1) * 2;

                for (int i = 0; i < aLines; i++)
                {

                    Console.WriteLine("");
                    for (int i1 = 0; i1 < (aTotalSymbols - aStars) / 2; i1++)
                    {
                        Console.Write(" ");
                    }

                    for (int i2 = 0; i2 < aStars; i2++)
                    {
                        Console.Write("*");
                    }
                    aStars = (aStars + 2);
                }

                for (int i = 0; i < aStem; i++)
                {
                    Console.WriteLine("");
                    for (int i1 = 0; i1 < (aTotalSymbols / 2.5); i1++)
                    {
                        Console.Write(" ");
                    }

                    for (int i2 = 0; i2 < aTotalSymbols / 5; i2++)
                    {
                        Console.Write("*");
                    }
                }

                Console.WriteLine("");
                DrawFirTree("Nupieskite dar viena eglute - iveskite eiluciu kieki (gali buti tik sveikas skaicius, pvz 15)");
            }
            else
            {
                Console.WriteLine("Netinkama reiksme!");
                DrawFirTree("Iveskite eglutes eiluciu kieki (gali buti tik sveikas skaicius, pvz 15)");
            }
        }
    }
}
/*
***
*****
*******/