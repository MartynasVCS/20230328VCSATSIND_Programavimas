using System;

namespace DemoIvedimas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Įveskite savo vardą: ");
            string ivedimas = Console.ReadLine();
            Console.WriteLine($"Jūsų vardas: {ivedimas}");
            Console.WriteLine();

            Console.Write("Įveskite savo amžių: ");
            Console.WriteLine($"Jūsų amžius: {Console.ReadLine()}");
            Console.WriteLine();

            Console.Write("Įveskite savo ūgį: ");
            ivedimas = Console.ReadLine();
            double ugis = Convert.ToDouble(ivedimas);
            Console.WriteLine($"Iki dviejų metrų ūgio jums trūksta: {2 - ugis}");
            Console.WriteLine();

            Console.Write("Įveskite savo svorį: ");
            double svoris = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Jūsų svoris: {svoris}");
            Console.WriteLine();

            Console.Write("Įveskite auginamų augintinių skaičių: ");
            Console.WriteLine($"Jūs turite: {Convert.ToInt32(Console.ReadLine())} augintinių");
            Console.WriteLine();
        } 
    }
}
