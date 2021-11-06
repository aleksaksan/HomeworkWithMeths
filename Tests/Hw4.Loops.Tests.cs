using NUnit.Framework;
using MyMethods;
using System;

namespace Tests
{
    public class Hw4Tests
    {
        Hw4 _hw;
        [SetUp]
        public void Setup()
        {
            _hw = new Hw4();
        }

        [TestCase(1000, new int[] { 1000 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]

        public void ReturnNumsWitchDivATest(int val, int[] expected)

        {
            //arrange

            //act
            var actual = _hw.ReturnNumsWitchDivA(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, "Attempted to divide by zero.")]

        public void ReturnNumsWitchDivANegativeTest(int val, string expected)

        {
            //arrange

            //act
            Exception ex = Assert.Throws(typeof(DivideByZeroException), () => _hw.ReturnNumsWitchDivA(val));
            //assert
            Assert.AreEqual(expected, ex.Message);
        }
        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(10, 3)]
        [TestCase(11, 3)]
        [TestCase(17, 4)]
        public void GetCountOfPosIfSqrLoverATest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetCountOfPosIfSqrLoverA(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-1, "вы ввели какую-то дичь! (скорее всего, число отрицательное)")]
        public void GetCountOfPosIfSqrLoverANegativeTest(int val, string expected)
        {

            Exception ex = Assert.Throws(typeof(ArgumentException), () => _hw.GetCountOfPosIfSqrLoverA(val));
            Assert.AreEqual(expected, ex.Message);
        }

        [TestCase(10, 5)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        [TestCase(100, 50)]
        public void GetMaxDivisorTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetMaxDivisor(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0, 0, 0)]
        [TestCase(0, 15, 21)]
        [TestCase(-14, 14, 0)]
        [TestCase(-21, -5, -42)]
        [TestCase(7, 21, 42)]
        public void GetSumDivisorOfSevensInRangeTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetSumDivisorOfSevensInRange(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(54, 24, 6)]
        [TestCase(91, 21, 7)]
        [TestCase(81, 72, 9)]
        [TestCase(25, 50, 25)]
        [TestCase(0, 50, 1)]
        public void GetGCDTest(int a, int b, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetGCD(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8, 2)]
        public void GetNumByMethOfHalfsDividesTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetCoubByMethOfHalfsDivides(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(811111, 5)]
        [TestCase(123456, 3)]
        [TestCase(888888, 0)]
        [TestCase(111888, 3)]
        [TestCase(-222111, 3)]
        public void GetCountOfOddsTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetCountOfOdds(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(811111, 111118)]
        [TestCase(123456, 654321)]
        [TestCase(888888, 888888)]
        [TestCase(0, 0)]
        [TestCase(-222111, -111222)]
        public void GetMirrorNumTest(int a, int expected)
        {
            //arrange

            //act
            int actual = _hw.GetMirrorNum(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(15, new int[] { 2, 4, 6, 8, 12, 14 })]
        [TestCase(20, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20 })]
        public void GetNumsEvensSumBiggerOddsTest(int a, int[] expected)
        {
            //arrange

            //act
            int[] actual = _hw.GetNumsEvensSumBiggerOdds(a);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(123, 3456789, "ДА")]
        [TestCase(666, 999, "НЕТ")]
        public void SayYesIfNumbersGotEqualsDigitsTest(int a, int b, string expected)
        {
            //arrange

            //act
            string actual = _hw.SayYesIfNumbersGotEqualsDigits(a, b);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
