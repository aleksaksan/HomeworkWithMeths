using NUnit.Framework;
using MyMethods;
using System;

namespace Tests
{
    public class Hw2Tests
    {
        Hw2 _hw2;
        [SetUp]
        public void Setup()
        {
            _hw2 = new Hw2();
        }

        [TestCase(735, new int[] { 5, 3, 7 })]
        [TestCase(12345, new int[] { 5, 4, 3, 2, 1 })]
        [TestCase(0, new int[] { 0 })]

        public void DivideOnDigitsTest(int val, int[] expected)
        {
            var actual = _hw2.DivideOnDigits(val);

            Assert.AreEqual(actual, expected);
        }
        
        [TestCase(new int[] { 5, 3, 7 }, 15)]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, 15)]
        [TestCase(new int[] { 0 }, 0)]
        [TestCase(new int[] { 1, -1 }, 0)]
        [TestCase(new int[] { -1, -2 }, -3)]

        public void SumInArrTest(int[] val, int expected)
        {
            var actual = _hw2.SumInArr(val);

            Assert.AreEqual(actual, expected);
        }
        [TestCase(new int[] { 5, 3, 7 }, new int[] { 7,3,5 })]
        [TestCase(new int[] { 5, 4, 3, 2, 1 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 1, -1 }, new int[] { -1, 1 })]
        [TestCase(new int[] { }, new int[] { })]

        public void WriteReverseArrTest(int[] val, int[] expected)
        {
            var actual = _hw2.WriteReverseArr(val);

            Assert.AreEqual(actual, expected);
        } 
        [TestCase(0,0,1, true)]
        [TestCase(1,1,4, true)]
        [TestCase(0,1,0.5, false)]
        [TestCase(1,1,0.5, false)]
        [TestCase(-1,-1,2, true)]

        public void IsInRoundTest(double x, double y, double rad, bool expected)
        {
            var actual = _hw2.IsInRound(x, y, rad);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(742, true)]
        [TestCase(773, true)]
        [TestCase(755, false)]
        [TestCase(354, false)]
        [TestCase(335, false)]

        public void IsInHalfTest(int val, bool expected)
        {
            var actual = _hw2.IsInHalf(_hw2.DivideOnDigits(val));

            Assert.AreEqual(actual, expected);
        }
        [TestCase(123, 321)]
        [TestCase(123456, 654321)]
        [TestCase(0, 0)]
        [TestCase(22, 22)]
        [TestCase(1, 1)]

        public void GetMirrorNumTest(int val, int expected)
        {
            //arrange

            //act
            int actual = _hw2.GetMirrorNum(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1.1, false)]
        [TestCase(123.456, false)]
        [TestCase(0, true)]
        [TestCase(22, true)]
        [TestCase(-1.1, false)]
        [TestCase(-11, true)]

        public void IsHaveFractPartTest(double val, bool expected)
        {
            //arrange

            //act
            var actual = _hw2.IsHaveFractPart(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
