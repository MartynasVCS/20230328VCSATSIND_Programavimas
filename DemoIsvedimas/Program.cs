using System;

namespace DemoIsvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Labas pasauli!");
            Console.WriteLine();

            Console.Write("Labas ");
            Console.Write("pasauli!");
            Console.WriteLine();
            Console.WriteLine();

            // Kintamųjų išvedimas
            string vardas = "Petras";
            int amzius = 25;
            Console.WriteLine(vardas);
            Console.WriteLine(amzius);

            // Teksto ir kintamojo išvedimas
            Console.WriteLine("Mano vardas: Petras, mano amžius: 25.");

            // 1 būdas
            Console.WriteLine("Mano vardas: " + vardas + ", mano amžius: " + 25 + ".");

            // 2 būdas
            Console.WriteLine("Mano vardas: {0}, mano amžius: {1}.", vardas, amzius);

            // 3 būdas (String interpolation)
            Console.WriteLine($"Mano vardas: {vardas}, mano amžius: {amzius}.");
        }
    }
}
