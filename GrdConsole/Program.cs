using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NaturalNumsLib;
namespace GrdConsole
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Введите первое число: ");
            int First = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int Second = int.Parse(Console.ReadLine());
            //Вызов функции НОД
            int Gcd = NaturalNumbers.GCD(First, Second);
            Console.WriteLine($"НОД({First}, {Second}) = {Gcd}");

            Console.WriteLine("Введите первое число: ");
            int First2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int Second2 = int.Parse(Console.ReadLine());
            //Вызов функции НОК
            int LCM = NaturalNumbers.LCM(First2, Second2);
            Console.WriteLine($"НОK({First2}, {Second2}) = {LCM}");
            Console.ReadKey();
        }
    }
}
