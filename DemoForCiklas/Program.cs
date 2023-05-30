using System;

namespace DemoForCiklas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            // int nuo žodžio integer
            // i nuo žodžio iterator

            // klasikinis for ciklas
            // vidinis kintamasis int tipo
            // vidinis kintamasis pavadinimu i
            // jis kinta nuo 0 iki kažkokios reikšmės
            // jis didėja arba mažėja po 1
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //skaicius = 10;
            //Console.WriteLine(skaicius);
            //Console.WriteLine(skaicius++);
            //Console.WriteLine(skaicius++);
            //Console.WriteLine(skaicius++);
            //Console.WriteLine(skaicius++);
            //Console.WriteLine(skaicius);
            //Console.WriteLine();

            int skaicius = 10;
            Console.WriteLine(skaicius);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(skaicius++);
            }
            Console.WriteLine(skaicius);
            Console.WriteLine();
        }
    }
}
