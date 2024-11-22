using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using NaturalNumsLib;
namespace NaturalsNumsTest
{
    [TestClass]
    public class EvenTest
    {
        //Тест на 2
        [TestMethod]
        public void TwoIsEvenNuber() // (eng) "2 - четное число"
        {
            // вызываем наш метод, чтобы получить фактический результат
            bool Result = NaturalNumbers.IsEven(2);
            // сравниваем с ожидаемым значением
            Assert.IsTrue(Result);
        }
        //Тест на 5
        [TestMethod]
        public void FiveIsOdd() // 5 - нечетное
        {
            bool Result = NaturalNumbers.IsEven(5);
            // обратите внимание!
            // правильная работа функции должна дать для 5
            // значение false
            Assert.IsFalse(Result);
        }
        //Тест на 2020
        [TestMethod]
        public void Value2020IsEven() // значение 2020 - четное
        {
            bool Result = NaturalNumbers.IsEven(2020);
            Assert.IsTrue(Result);
        }

    }
    [TestClass]
    public class GcdTests
    {
        //Тест на одинаковые значения
        [TestMethod]
        public void SameValues()
        {
            // ожидаемое значение
            int Expected = 888;
            // фактическое значение, результат работы разработанного метода
            int Actual = NaturalNumbers.GCD(888, 888);
            // тест пройден, если они совпали
            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        //Тест на нуль
        public void Zero()
        {
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(0, 5));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(5, 0));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(0, 0));
        }
        [TestMethod] // ниже напишем тесты для GCD
        //Тест на числа 24 и 32
        public void DiffrentGcd()
        {
            // ожидаемое значение
            int Expected = 8;
            // фактическое значение, результат работы разработанного метода
            int Actual = NaturalNumbers.GCD(24, 32);
            // тест пройден, если они совпали
            Assert.AreEqual(Expected, Actual);
        }
        //Тест на 45 и 15
        [TestMethod]
        public void With15and45()
        {
            Assert.AreEqual(15, NaturalNumbers.GCD(45, 15));
            Assert.AreEqual(15, NaturalNumbers.GCD(15, 45));
        }
        //Тест на 49 и 50
        [TestMethod] // важно написать [Test], чтобы метод был виден как тестовый!
        public void WithOne()
        {
            // ожидаемое значение
            int Expected = 1;
            // фактическое значение, результат работы разработанного метода
            int Actual = NaturalNumbers.GCD(49, 50);
            // тест пройден, если они совпали
            Assert.AreEqual(Expected, Actual);
        }
        //Тест на отрицательные значения
        [TestMethod]
        public void Negativ()
        {
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(-10, -15));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(10, -15));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.GCD(-10, 15));

        }
       
    }
    [TestClass]
    public class IsPrimeTests
    {
        [TestMethod]
        //Тест на 3
        public void TestIsPrime1()
        {
            bool Expected = true;
            bool Actual = NaturalNumbers.IsPrime(3);
            Assert.AreEqual(Expected, Actual);
        }
        //Тест на 12
        [TestMethod]
        public void TestIsPrime2()
        {
            bool Expected = false;
            bool Actual = NaturalNumbers.IsPrime(12);
            Assert.AreEqual(Expected, Actual);
        }
        //Тест на 0
        [TestMethod]
        public void TestIsPrime3()
        {
            bool Expected = false;
            bool Actual = NaturalNumbers.IsPrime(0);
            Assert.AreEqual(Expected, Actual);
        }
        //Тест на 1
        [TestMethod]
        public void TestIsPrime4()
        {
            bool Expected = false;
            bool Actual = NaturalNumbers.IsPrime(1);
            Assert.AreEqual(Expected, Actual);
        }
        //Тест на отрицательное значение
        [TestMethod]
        public void TestIsPrime5()
        {
            bool Expected = false;
            bool Actual = NaturalNumbers.IsPrime(-7);
            Assert.AreEqual(Expected, Actual);
        }
    }
    [TestClass]
    public class LCMTests
    {
        //Тест на 4 и 5
        [TestMethod]
        public void TestWithPositiveNumbers()
        {
            Assert.AreEqual(20, NaturalNumbers.LCM(4, 5));
            Assert.AreEqual(12, NaturalNumbers.LCM(4, 6));
            Assert.AreEqual(30, NaturalNumbers.LCM(5, 6));
        }
        //Тест на отрицательные значения
        [TestMethod]
        public void TesWithNegativeNumbers()
        {
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(-48, 18));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(48, -18));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(-48, -18));
        }
        //Тест на одинаковые значения
        [TestMethod]
        public void TestWithSame()
        {
            Assert.AreEqual(7, NaturalNumbers.LCM(7, 7));
        }
        //Тест на 0
        [TestMethod]
        public void TestWithZero()
        {
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(0, 5));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(5, 0));
            Assert.ThrowsException<Exception>(() => NaturalNumbers.LCM(0, 0)); 
        }
        //Тест на 1
        [TestMethod]
        public void TestWithOne()
        {
            Assert.AreEqual(5, NaturalNumbers.LCM(1, 5));
            Assert.AreEqual(7, NaturalNumbers.LCM(1, 7));
        }
    }
}
   
    



   

