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
            if (BMI <= 1! & BMI >=  20) 
            {
                Console.WriteLine("Trošku hubenější jakože");
            }
            if (BMI <= 21! & BMI >= 25) 
            {
                Console.WriteLine("Ideálka kámo");
            }
            if (BMI <= 26! & BMI >= 30) 
            {
                Console.WriteLine("Měl by jsi začít hubnout");
            }
            if (BMI >= 31) 
            {
                Console.WriteLine("Tlustší jak Homer Simpson");
            }
        }
    }
}
