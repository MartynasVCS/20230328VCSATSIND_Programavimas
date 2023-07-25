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

            Console.WriteLine(automobilisPetro.marke);
            Console.WriteLine(automobilisMonikos.marke);
            Console.WriteLine(automobilisPetro.spalva);
            Console.WriteLine(automobilisMonikos.spalva);
            Console.WriteLine(Automobilis.ratuSkaicius);
            Console.WriteLine();

            Zmogus zmogusPetras = new Zmogus("Petras", 35);
            Zmogus zmogusMonika = new Zmogus("Monika", 28);
            Zmogus vaiduoklis = new Zmogus();

            zmogusPetras.Prisistatyti();
            zmogusMonika.Prisistatyti();
            vaiduoklis.Prisistatyti();

            Console.WriteLine(zmogusPetras.vardas);
            zmogusPetras.vardas = "Paulius";
            Console.WriteLine(zmogusPetras.vardas);
        }
    }
}
