using System;

namespace DemoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("PROGRAMOS PRADŽIA");
            Console.WriteLine();

            double skaicius = 5;

            switch(skaicius)
            {
                case 4:
                    Console.WriteLine($"Skaičius yra 4");
                    break;
                case 5:
                    Console.WriteLine($"Skaičius yra 5");
                    break;
                default:
                    Console.WriteLine($"Skaičius yra nei 4 nei 5");
                    break;
            }

            string gyvunas = "žąsis";
            switch (gyvunas)
            {
                case "šuo":
                    Console.WriteLine($"Gyvūnas yra šuo");
                    break;
                case "katė":
                    Console.WriteLine($"Gyvūnas yra katė");
                    break;
                case "pelėda":
                    Console.WriteLine($"Gyvūnas yra pelėda");
                    break;
                default:
                    Console.WriteLine($"Kažkoks nežinomas gyvūnas");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("PROGRAMOS PABAIGA");
            Console.WriteLine();
        }
    }
}
