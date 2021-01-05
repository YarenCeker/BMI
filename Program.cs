using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Kilonuzu Giriniz (kg) =");
            double kilo = Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("Boyunuzu Giriniz (m) =");
            double boy = Convert.ToDouble(Console.ReadLine());
            double BMI = kilo / (boy * boy);
            System.Console.WriteLine("BMI Değerin = " + Math.Round(BMI, 2));
            Console.ReadLine();


            if (BMI <= 18)
            {
                System.Console.WriteLine("Zayıf");
            }
            else if (18 < BMI <= 25)
            {
                System.Console.WriteLine("Normal Kilo");
            }
            else if (25 < BMI <= 30)
            {
                System.Console.WriteLine("Hafif Kilolu");
            }
            else if (30 < BMI <= 35)
            {
                System.Console.WriteLine("Orta Derecede Kilolu (I)");
            }
            else if (35 < BMI <= 40)
            {
                System.Console.WriteLine("Ağır Derecede Kilolu (II)");
            }
            else
            {
                System.Console.WriteLine("Çok Ağır Derecede Kilolu (III)");
            }
            Console.ReadLine();
        }
        
    }
}
