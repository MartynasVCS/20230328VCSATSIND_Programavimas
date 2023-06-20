using System;
using System.Linq;

namespace DemoMasyvai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            string vardas1 = "Petras";
            string vardas2 = "Paulius";
            string vardas3 = "Antanas";

            // Masyvas iš konkrečių reikšmių
            string[] varduMasyvasIsKonkreciuReiksmiu = { "Petras", "Paulius", "Antanas" };
            
            // Konkretaus dydžio masyvas
            string[] varduMasyvasKonkretausDydzio = new string[3];
            int[] amziuMasyvas = new int[5];

            // Reikšmių perrašymas
            varduMasyvasIsKonkreciuReiksmiu[0] = "Birutė";
            varduMasyvasKonkretausDydzio[0] = "Smiltė";
            varduMasyvasKonkretausDydzio[1] = "Saulius";
            varduMasyvasKonkretausDydzio[2] = "Šarūnas";

            // Reikšmių nuskaitymas
            Console.WriteLine(varduMasyvasIsKonkreciuReiksmiu[0]);
            Console.WriteLine(varduMasyvasIsKonkreciuReiksmiu[2]);
            Console.WriteLine();

            // Masyvo elementų kiekis
            Console.WriteLine(varduMasyvasIsKonkreciuReiksmiu.Length);
            Console.WriteLine();

            // Masyvo pirma reikšmė
            Console.WriteLine(varduMasyvasIsKonkreciuReiksmiu[0]);
            Console.WriteLine(varduMasyvasIsKonkreciuReiksmiu.First());
            Console.WriteLine();

            // Masyvo paskutinė reikšmė
            Console.WriteLine(varduMasyvasIsKonkreciuReiksmiu[varduMasyvasIsKonkreciuReiksmiu.Length - 1]);
            Console.WriteLine(varduMasyvasIsKonkreciuReiksmiu.Last());
            Console.WriteLine();

            // Masyvo reikšmių spausdinimas
            for (int i = 0; i < varduMasyvasIsKonkreciuReiksmiu.Length; i++)
            {
                Console.WriteLine(varduMasyvasIsKonkreciuReiksmiu[i]);
                Console.WriteLine(varduMasyvasKonkretausDydzio[i]);
            }
            Console.WriteLine();

            foreach (string vardas in varduMasyvasIsKonkreciuReiksmiu)
            {
                Console.WriteLine(vardas);
            }
            Console.WriteLine();

            int[] skaiciai = { 6, 7, 9, 2 };

            // Sumos algoritmas
            int suma = 0;
            for (int i = 0; i < skaiciai.Length; i++)
            {
                suma += skaiciai[i];
            }
            Console.WriteLine(suma);
            Console.WriteLine();

            // Maksimalios reikšmės algoritmas
            int max = skaiciai[0];
            for (int i = 0; i < skaiciai.Length; i++)
            {
                if (skaiciai[i] > max)
                {
                    max = skaiciai[i];
                }
            }
            Console.WriteLine(max);
            Console.WriteLine();
        }
    }
}
