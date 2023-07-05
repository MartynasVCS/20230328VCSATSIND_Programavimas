using System;

namespace DemoMetodai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Pasisveikinimas();
            Console.WriteLine();

            string vardas = "Monika";
            int amzius = 19;
            PasisveikinimasSuVardu("Petrai");
            PasisveikinimasSuVardu(vardas);
            PasisveikinimasSuVardu("1265446546");
            Console.WriteLine();

            PasisveikinimasSuVarduIrPavarde("Aiste", "Petrauskaite");
            PasisveikinimasSuVarduIrPavarde(vardas, "Sabaliauskaite");
            Console.WriteLine();

            PasisveikinimasSuVarduIrAmziumi(vardas, amzius);
            PasisveikinimasSuVarduIrAmziumi("Petrai", 25);
            Console.WriteLine();

            int suma = TrijuSveikujuSkaiciuSuma(5, 7, 15);
            Console.WriteLine(suma);
            Console.WriteLine(TrijuSveikujuSkaiciuSuma(3, 3, 3));
            Console.WriteLine();

            // nestatinių metodų kvietimas
            Skaiciuotuvas skaiciuotuvas = new Skaiciuotuvas();
            suma = skaiciuotuvas.Suma(5, 7);
            Console.WriteLine(suma);

            // statinių metodų kvietimas
            int skirtumas = Skaiciuotuvas.Skirtumas(9, 4);
            Console.WriteLine(skirtumas);
        }

        static void Pasisveikinimas()
        {
            Console.WriteLine("Labas pasauli!");
        }

        static void PasisveikinimasSuVardu(string vardas)
        {
            Console.WriteLine($"Labas, {vardas}");
        }

        static void PasisveikinimasSuVarduIrPavarde(string vardas, string pavarde)
        {
            Console.WriteLine($"Labas, {vardas} {pavarde}");
        }

        static void PasisveikinimasSuVarduIrAmziumi(string vardas, int amzius)
        {
            Console.WriteLine($"Labas, žmogau {vardas}, kuriam yra {amzius} metų");
        }

        static int TrijuSveikujuSkaiciuSuma(int skaicius1, int skaicius2, int skaicius3)
        {
            return skaicius1 + skaicius2 + skaicius3;
        } 
    }
}
