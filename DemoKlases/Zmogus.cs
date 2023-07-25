using System;

namespace DemoKlases
{
    internal class Zmogus
    {
        internal string vardas { get; set; }
        internal string pavarde;
        internal int amzius;

        internal Zmogus()
        {

        }

        internal Zmogus(string vardas, int amzius)
        {
            this.vardas = vardas;
            this.amzius = amzius;
        }

        internal Zmogus(string vardas)
        {
            this.vardas = vardas;
        }

        internal void Prisistatyti()
        {
            Console.WriteLine($"Mano vardas yra {vardas}");
        }
    }
}
