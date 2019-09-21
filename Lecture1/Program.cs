using System;
using System.Globalization;

namespace Drawing_Of_Figures
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Piesiam eglute");
            SelectWhatToDraw("Pasirinkite ka noretumet nupiesti (iveskite numeri):");
        }

        static void SelectWhatToDraw(string aMessage)
        {            
            Console.WriteLine(aMessage);
            Console.WriteLine("1 - Eglute");
            Console.WriteLine("2 - Rombas");
            Console.WriteLine("3 - Eglute kitu budu");

            string aValue = Console.ReadLine();
            //int aNo;

            if (int.TryParse(aValue, out int aNo))
            {
                if (aNo == 1)
                {
                    DrawFirTree("Iveskite eglutes eiluciu kieki (gali buti tik sveikas skaicius, pvz 15)");
                }
                else if (aNo == 2)
                {
                    DrawDiamon("Iveskite rombo eiluciu kieki (gali buti tik sveikas skaicius, pvz 10)");
                }
                else if (aNo == 3)
                {
                    DrawFirTreeDiferent("Iveskite eglutes eiluciu kieki (gali buti tik sveikas skaicius, pvz 15)");
                }
                else
                {
                    SelectWhatToDraw("Rinkites is pateiktu numeriu");                    
                }
            }
            else
            {
                Console.WriteLine("Ivedete netinkama reiksme! Gasli buti tik sveikas skaicius.");
                SelectWhatToDraw("Bandykite dar karta");
            }

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
                SelectWhatToDraw("Nupieskite dar ka nors");
            }
            else
            {
                Console.WriteLine("Netinkama reiksme!");
                DrawFirTree("Iveskite eglutes eiluciu kieki (gali buti tik sveikas skaicius, pvz 15)");
            }
        }

        static void DrawFirTreeDiferent(string aMessage)
        {
            int aLines;
            Console.WriteLine(aMessage);
            string aString = Console.ReadLine();

            if (int.TryParse(aString, out aLines))
            {
                int aStars = 1, aStem = aLines / 3;
                int aTotalSymbols = 1 + (aLines - 1) * 2;

                //Console.WriteLine(new string('*', 1));

                for (int i = 0; i < aLines; i++)
                {
                    Console.WriteLine((new string(' ', (aTotalSymbols - aStars) / 2)) + (new string('*', aStars))); 
                    aStars = aStars += 2;
                }

                Console.WriteLine("");
                SelectWhatToDraw("Nupieskite dar ka nors");
            }
            else
            {
                Console.WriteLine("Netinkama reiksme!");
                DrawFirTree("Iveskite eglutes eiluciu kieki (gali buti tik sveikas skaicius, pvz 15)");
            }
        }

        static void DrawDiamon(string aMessage)
        {
            int aLines;
            Console.WriteLine(aMessage);
            string aString = Console.ReadLine();

            if (int.TryParse(aString, out aLines))
            {
                int aStars = 1;
                int aFirstHalf = aLines / 2, aSecondtHalf = aLines / 2 - 1;
                int aTotalSymbolsFirst = 1 + (aFirstHalf - 1) * 2;

                for (int i = 0; i < aFirstHalf; i++)
                {

                    Console.WriteLine("");
                    for (int i1 = 0; i1 < (aTotalSymbolsFirst - aStars) / 2; i1++)
                    {
                        Console.Write(" ");
                    }

                    for (int i2 = 0; i2 < aStars; i2++)
                    {
                        Console.Write("*");
                    }
                    aStars = (aStars + 2);
                }

                aStars = (aStars - 4);

                for (int i = 0; i < aSecondtHalf; i++)
                {
                    Console.WriteLine("");
                    for (int i1 = 0; i1 < ((aTotalSymbolsFirst) - aStars) /2; i1++)
                    {
                        Console.Write(" ");
                    }

                    for (int i2 = 0; i2 < aStars; i2++)
                    {
                        Console.Write("*");
                    }
                    aStars = (aStars - 2);
                } 

                Console.WriteLine("");
                SelectWhatToDraw("Nupieskite dar ka nors");
               
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