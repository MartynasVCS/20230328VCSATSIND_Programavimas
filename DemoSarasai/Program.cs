using System;
using System.Collections.Generic;

namespace DemoSarasai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // Tuščio sąrašo kūrimas
            List<int> amziuSarasas = new List<int>();

            // Sąrašas iš reikšmių
            List<string> varduSarasas = new List<string>() { "Petras", "Paulius", "Antanas" };

            // Sąrašo reikšmių spausdinimas
            // for...
            foreach (string vardas in varduSarasas)
            {
                Console.WriteLine(vardas);
            }
            Console.WriteLine();

            // Reikšmių perrašymas
            varduSarasas[0] = "Smiltė";

            // Reikšmių pridėjimas
            varduSarasas.Add("Saulė");
            varduSarasas.Add("Ąžuolas");

            // Sąrašo reikšmių spausdinimas
            // for...
            foreach (string vardas in varduSarasas)
            {
                Console.WriteLine(vardas);
            }
            Console.WriteLine();
        }
    }
}
