using System;

namespace DemoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int skaicius = 5;
            // amžinas ciklas
            //while (skaicius < 10)
            //{
            //    Console.WriteLine(skaicius);
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //Duomenų tipo įvedimo apsauga

            //Console.Write("Įveskite savo ūgį: ");
            //string ivedimas = Console.ReadLine();
            //double ugis = Convert.ToDouble(ivedimas);
            //Console.WriteLine($"Iki dviejų metrų ūgio jums trūksta: {2 - ugis}");
            //Console.WriteLine();

            // reiksme
            // reiskme == true

            // !reiksme
            // reiksme != true

            bool arBuvoIvestasSkaicius = false;
            while (!arBuvoIvestasSkaicius)
            {
                try
                {
                    Console.Write("Įveskite savo ūgį: ");
                    string ivedimas = Console.ReadLine();
                    double ugis = Convert.ToDouble(ivedimas);
                    Console.WriteLine($"Iki dviejų metrų ūgio jums trūksta: {2 - ugis}");
                    arBuvoIvestasSkaicius = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Įvedėte ne skaičių, bandykite dar kartą.");
                }
                catch (Exception exception)
                {
                    throw exception;
                }
            }
        }
    }
}
