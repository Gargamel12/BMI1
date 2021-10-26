using System;
namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {
                

                    double Hmotnost;
                    Double Výška;
               while (true)
               { 
                    Console.WriteLine("Výpočet BMI");
                    Console.WriteLine("==========");
                    Console.Write("Zadej váhu(kg):");
                    Hmotnost = double.Parse(Console.ReadLine());
                    if (Hmotnost < 0)
                    {
                        Console.Write("Napište číslo větší jak 0");
                    }
                    Console.WriteLine("Zadej výšku(m):");
                    Výška = double.Parse(Console.ReadLine());
                    if (Výška < 0)
                    {
                        Console.Write("Napiště číslo větší jak 0");
                    }
                    var BMI = Hmotnost / (Výška * Výška);
                    BMI = Math.Floor(BMI);
                    Console.WriteLine($"Vaše BMI je {BMI} ");
                    if (BMI > 1! & BMI <= 20)
                    {
                        Console.WriteLine("Trošku hubenější jakože");
                    }
                    if (BMI > 21! & BMI <= 25)
                    {
                        Console.WriteLine("Ideálka kámo");
                    }
                    if (BMI > 26! & BMI <= 30)
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
}
