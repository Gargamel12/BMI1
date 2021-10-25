using System;
namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            double Hmotnost;
            Double Výška;
            Console.WriteLine("Výpočet BMI");
            Console.WriteLine("==========");
            Console.Write("Zadej váhu(kg):");
            Hmotnost = double.Parse(Console.ReadLine());
            Console.WriteLine("Zadej výšku(m):");
            Výška = double.Parse(Console.ReadLine());
            var BMI = Hmotnost / (Výška * Výška);
            Console.WriteLine($"Vaše BMI je {BMI} ");
            Console.ReadLine();


        }
    }
}
