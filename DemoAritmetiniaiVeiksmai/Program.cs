using System;

namespace DemoAritmetiniaiVeiksmai
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int sudetis = 2 + 3;
            Console.WriteLine(sudetis);
            Console.WriteLine(2 + 3);
            Console.WriteLine();

            Console.WriteLine(5 * 3 + 2);
            Console.WriteLine(2 + 3 * 5);
            Console.WriteLine(5 * (3 + 2));
            Console.WriteLine();

            // Sveikųjų skaičių dalyba
            Console.WriteLine(12 / 4);
            Console.WriteLine(11 / 4); // sveikoji dalis
            Console.WriteLine(11 % 4); // liekana
            Console.WriteLine();

            // Realiųjų skaičių dalyba
            Console.WriteLine(11f / 4);
            Console.WriteLine(11f / 4f);
            Console.WriteLine(11.0 / 4);
            Console.WriteLine(11 / 4.0);
            Console.WriteLine();

            // Casting
            int dalinys = 11;
            int daliklis = 4;
            Console.WriteLine(dalinys * 1.0 / daliklis); // primityvu
            Console.WriteLine((double)dalinys / daliklis);
            Console.WriteLine(dalinys / (double)daliklis);

            // Dalyba iš nulio
            Console.WriteLine(1 / 0.0);
            Console.WriteLine();

            // Kintamojo reikšmės perrašymas panaudojant prieš tai buvusią reikšmę
            int skaicius = 10; // norime padidinti reikšmę penketu
            skaicius = 15; // galim tiesiog perrašyti, bet čia remiamės tuo, kad žinome kokia reikšmė yra dabar
            skaicius = skaicius + 5; // imame seną reikšmę ir padidiname ją penketu
            skaicius += 5; // ta pati operacija, tik trumpesnis užrašymas
            skaicius *= 5;
            skaicius -= 5;

            // Skaičius didinimas / mažinimas vienetu
            skaicius = 10;
            skaicius = skaicius + 1;
            skaicius += 1;
            skaicius++;

            // skaicius++ ir ++skaicius
            skaicius = 10;
            Console.WriteLine(skaicius);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius++);
            Console.WriteLine(skaicius);
            Console.WriteLine();

            skaicius = 10;
            Console.WriteLine(skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(++skaicius);
            Console.WriteLine(skaicius);
            Console.WriteLine();

            // Įvairios matematinės operacijos
            Console.WriteLine(5 * 5); // skaičius kvadratu / skaičius antruoju laipsniu
            Console.WriteLine(5 * 5 * 5); // skaičius kubu
            Console.WriteLine(5 * 5 * 5 * 5); // skaičius ketvirtuoju laipsniu
            Console.WriteLine(Math.Pow(5, 4)); // skaičius ketvirtuoju laipsniu
            Console.WriteLine(Math.Sqrt(5)); // kvadratinė šaknis
            Console.WriteLine(Math.Pow(5, (double)1 / 2)); // kvadratinė šaknis
        }
    }
}
