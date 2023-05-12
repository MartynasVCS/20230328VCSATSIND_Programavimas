using System;

namespace DemoKintamieji
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Skaitinių reikšmių kintamieji
            int skaiciusSveikasis = 7;
            double skaiciusDouble = 7.5;
            float skaiciusFloat = 7.5f;

            skaiciusSveikasis = 8;

            // Tekstinės reikšmės
            char simbolis = '$';
            string tekstas = "$a 12 bc įčįčę @!%!*";
            string vardas = "Martynas";

            // Loginis
            bool arPenktadienis = true;
            bool arLyja = false;

            Console.WriteLine(vardas);
            Console.WriteLine(skaiciusSveikasis);
        }
    }
}
