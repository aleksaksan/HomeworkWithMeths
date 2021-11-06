using NUnit.Framework;
using MyMethods;
using System;

namespace Tests
{
    public class Hw1Tests
    {
        Hw1 _hw1;
        [SetUp]
        public void Setup()
        {
            _hw1 = new Hw1();
        }

        [TestCase(1, 2, 21)]
        [TestCase(1, -2, -7)]
        [TestCase(1, 0, - 5)]
        [TestCase(0, 1, 1)]
        [TestCase(-1, -2, -11)]

        public void GetMathCalcTest(double var1, double var2, double expected)
        {
            var actual = _hw1.GetMathCalc(var1, var2);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(-1, -1, "на ноль делить нельзя!")]

        public void GetMathCalcNegativeTest(double var1, double var2, string expected)
        {

            Exception ex = Assert.Throws(typeof(DivideByZeroException), () => _hw1.GetMathCalc(var1, var2));
            Assert.AreEqual(expected, ex.Message);
        }

        //(numC - numB) / numA;
        [TestCase(10, 10, 10, 0)]
        [TestCase(2, 5, 10, 2.5)]
        [TestCase(-3, 1, -2, 1)]
        [TestCase(-3, 1, 4, -1)]
        [TestCase(-1, -2, -1, -1)]

        public void GetXTest(int a, int b, int c, double expected)
        {
            //arrange

            //act
            double actual = _hw1.GetX(a, b, c);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 5, 10, "Value cannot be null.")]
        [TestCase(-3, 0, -2, "Value cannot be null.")]
        [TestCase(-3, 1, 0, "Value cannot be null.")]
        [TestCase(0, 0, 0, "Value cannot be null.")]
        [TestCase(0, 10, 0, "Value cannot be null.")]

        public void GetXNegaTest(int a, int b, int c, string expected)
        {
            Exception ex = Assert.Throws(typeof(ArgumentNullException), () => _hw1.GetX(a, b, c));
            Assert.AreEqual(expected, ex.Message);
        }
    }
}