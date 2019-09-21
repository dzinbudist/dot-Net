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
            Console.WriteLine("Paprastas skaičiuotuvas. Programa gali sudėti, atimti, dauginti ir dalinti du vartotojo įvestus skaičius.");
            CheckValue("Įveskite pirmą reikšmę", 1);
        }

        static void CheckValue(string aMessage, int aValueNo)
        {
            Console.WriteLine(aMessage);
            float aConvertedFloat;
            string aValue = Console.ReadLine();
            aValue = aValue.Replace(',', '.');

            if (String.IsNullOrEmpty(aValue))
            {
                Console.WriteLine("Reikšmė negali būti tuščia!");

                if (aValueNo == 1)
                {
                    CheckValue("Įveskite pirmą reikšmę", 1);
                }
                else
                {
                    CheckValue("Įveskite antrą reikšmę", 2);
                }
            }
            else
            {
                if (float.TryParse(aValue, out aConvertedFloat))
                {
                    if (aValueNo == 1)
                    {
                        aFirstValue = aConvertedFloat;
                        GetOperator();
                    }
                    else
                    {
                        aSecondValue = aConvertedFloat;
                        DoTheMath();
                    }
                }
                else
                {
                    Console.WriteLine("Netinkama reikšmė! Reikšmėje negali būti raidžių ir simbolių. Tinkamos reikšmės pvz: 5 arba 5.2");
                    if (aValueNo == 1)
                    {
                        CheckValue("Įveskite pirmą reikšmę", 1);
                    }
                    else
                    {
                        CheckValue("Įveskite antrą reikšmę", 2);
                    }
                }
            }
        }

        static void GetOperator()
        {
            Console.WriteLine("Įveskite matematinio veiksmo simbolį (+, -, *, /)");
            aSymbol = Console.ReadLine();

            if (aSymbol == "+" || aSymbol == "-" || aSymbol == "*" || aSymbol == "/")
            {
                CheckValue("Įveskite antrą reikšmę", 2);
            }
            else
            {
                Console.WriteLine("Neteisingas matematinio veiksmo simbolis!");
                GetOperator();
            }
        }

        static void DoTheMath()
        {
            if (aSymbol == "+")
            {
                Console.WriteLine(aFirstValue + " " + aSymbol + " " + aSecondValue + " = " + (aFirstValue + aSecondValue));
                KeepWorking();
            }
            else if (aSymbol == "-")
            {
                Console.WriteLine(aFirstValue + " " + aSymbol + " " + aSecondValue + " = " + (aFirstValue - aSecondValue));
                KeepWorking();
            }
            else if (aSymbol == "*")
            {
                Console.WriteLine(aFirstValue + " " + aSymbol + " " + aSecondValue + " = " + (aFirstValue * aSecondValue));
                KeepWorking();
            }
            else if (aSymbol == "/")
            {
                if (aSecondValue != 0)
                {
                    Console.WriteLine(aFirstValue + " " + aSymbol + " " + aSecondValue + " = " + (aFirstValue / aSecondValue));
                    KeepWorking();
                }
                else
                {
                    Console.WriteLine("Dalyba iš nulio negalima!");
                    KeepWorking();
                }
            }
        }

        static void KeepWorking()
        {
            Console.WriteLine("Ar norite tęsti darbą?");
            Console.WriteLine("Y/N");
            string aValue = Console.ReadLine();

            if (aValue.ToUpper() == "Y")
            {
                CheckValue("Įveskite pirmą reikšmę", 1);
            }
            else if (aValue.ToUpper() == "N")
            {
                Console.WriteLine("Viso geriausio");
            }
            else
            {
                KeepWorking();
            }
        }
    }
}
