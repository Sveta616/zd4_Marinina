using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaturalNumsLib
{
    public static class NaturalNumbers
    {
        //Метод проверки на чётность
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
        //Метод проверки на НОД
        public static int GCD(int A, int B) // greatest common divisor (GCD)
        {
            if (A < 0 || B < 0)
            {
                throw new Exception("Все числа должны быть больше нуля");
            }
            if (A == 0 || B == 0)
            {
                throw new Exception("Все числа должны быть больше нуля");
            }
            int nod = 0;
            if (A != 0 && B != 0)
            {
                if (A > B)
                {
                    for (int i = 1; i <= B; i++)
                    {
                        if (A % i == 0 && B % i == 0)
                            nod = i;


                    }
                    return nod;
                }
                else
                {
                    for (int i = 1; i <= A; i++)
                    {
                        if (A % i == 0 && B % i == 0)
                            nod = i;
                    }
                    return nod;
                }

            }
            else
            {
                return A + B;
            }
        }
        //Метод проверки на простое число
        public static bool IsPrime(int number)
        {
            if (number < 0)
            {
                return false;
            }
            if (number == 0)
            {
                return false;
            }
            if (number == 1)
            {
                return false;
            }
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
        //Метод проверки на НОК
        public static int LCM(int A, int B)
        {
            if (A == 0 || B == 0)
            {
                throw new Exception("Числа не могут быть равны 0");
            }
            if (A < 0 || B < 0)
            {
                throw new Exception("Нельзя отрицательные числа");
            }
            return Math.Abs(A * B) / GCD(A, B);
        }
    }
}
    

