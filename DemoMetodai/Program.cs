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
            Pasisveikinimas();
            Pasisveikinimas();
            Pasisveikinimas();
        }

        static void Pasisveikinimas()
        {
            Console.WriteLine("Labas");
            Console.WriteLine("rytas");
            Console.WriteLine("!");
        }
    }
}
