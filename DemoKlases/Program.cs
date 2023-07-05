using System;

namespace DemoKlases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Automobilis automobilisPetro = new Automobilis("Audi", "žalia");
            Automobilis automobilisMonikos = new Automobilis("BMW", "raudona");

            Console.WriteLine(automobilisPetro.spalva);
            Console.WriteLine(automobilisMonikos.spalva);
            Console.WriteLine(automobilisPetro.marke);
            Console.WriteLine(automobilisMonikos.marke);
            Console.WriteLine(Automobilis.ratuSkaicius);
        }
    }
}
