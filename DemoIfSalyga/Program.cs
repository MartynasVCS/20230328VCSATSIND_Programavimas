using System;

namespace DemoIfSalyga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Lietuviškų simbolių rodymas
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("PROGRAMOS PRADŽIA");
            Console.WriteLine();

            Console.Write("Įveskite sveikąjį skaičių: ");
            double skaicius = Convert.ToDouble(Console.ReadLine());
            
            // Nepriklausomos if sąlygos
            if (skaicius > 4)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 4");
            }

            if (skaicius > 3)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 3");
            }

            if (skaicius > 2)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 2");
            }
            Console.WriteLine();

            // Jungtinės if sąlygos
            if (skaicius > 4)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 4");
            }
            else if (skaicius > 3)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 3");
            }
            else if (skaicius > 2)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 2");
            }
            Console.WriteLine();

            // Pilna if sąlyga
            if (skaicius > 4)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 4");
            }
            else if (skaicius > 3)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 3");
            }
            else if (skaicius > 2)
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra didesnis už 2");
            }
            else
            {
                Console.WriteLine($"Jūsų įvestas skaičius yra mažesnis už 2 arba lygus 2");
            }

            Console.WriteLine("PROGRAMOS PABAIGA");
            Console.WriteLine();
        }
    }
}
