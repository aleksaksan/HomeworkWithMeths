using NUnit.Framework;
using MyMethods;
using System;

namespace Tests
{
    public class Hw3Tests
    {
        Hw3 _hw;
        [SetUp]
        public void Setup()
        {
            _hw = new Hw3();
        }

        [TestCase(2, 1, "A+B=3")]
        [TestCase(0, -2, "A+B=-2")]
        [TestCase(1, 1, "A*B=1")]
        [TestCase(0, 0, "A*B=0")]
        [TestCase(-3, 0, "A-B=-3")]
        [TestCase(0, 3, "A-B=-3")]

        public void GetMathCalcTest(int val1, int val2, string expected)
        {
            var actual = _hw.GetAnswerOfTask1(val1, val2);

            Assert.AreEqual(actual, expected);
        }
        [TestCase(1, 1, 1)]
        [TestCase(-1, 2, 2)]
        [TestCase(-1, -1, 3)]
        [TestCase(1, -1, 4)]
        [TestCase(0, 0, 0)]
        [TestCase(0, 3, 5)]
        [TestCase(3, 0, 6)]
        //if (numX > 0 && numY > 0)
        //        return 1;
        //    else if (numX< 0 && numY> 0)
        //        return 2;
        //    else if (numX< 0 && numY< 0)
        //        return 3;
        //    else if (numX > 0 && numY< 0)
        //        return 4;
        //    else if (numX == 0 && numY == 0)
        //        return 0;
        //    else if (numX == 0)
        //        return 5;
        //    else if (numY == 0)
        //        return 6;
        //    else return int.MinValue;
        public void GetIntQuarterTest(int val1, int val2, int expected)
        {
            var actual = _hw.GetIntQuarter(val1, val2);

            Assert.AreEqual(actual, expected);
        }
        [TestCase(0, 0, "точка находится на оси Y")]
        [TestCase(1, 1, "Точка с координатами находится в I четверти")]
        [TestCase(-1, 2, "Точка с координатами находится в II четверти")]
        [TestCase(-1, -1, "Точка с координатами находится в III четверти")]
        [TestCase(1, -1, "Точка с координатами находится в IV четверти")]
        [TestCase(0, 3, "точка находится на оси X")]
        [TestCase(3, 0, "точка находится на оси Y")]

        public void ShowQuarterTest(int val1, int val2, string expected)
        {
            var actual = _hw.ShowQuarter(_hw.GetIntQuarter(val1, val2));

            Assert.AreEqual(actual, expected);
        }
        [TestCase(2, 2, 1, "1 2 2")]
        [TestCase(3, 2, 1, "1 2 3")]
        [TestCase(1, 0, -1, "-1 0 1")]
        [TestCase(-1, -2, -3, "-3 -2 -1")]

        public void GetIncreaseAnswerTest(int val1, int val2, int val3, string expected)
        {
            var actual = _hw.GetIncreaseAnswer(val1, val2, val3);

            Assert.AreEqual(actual, expected);
        }

        [TestCase(new int[] { 1, -2, -24 }, 100.0)]
        [TestCase(new int[] { 42, 0, 0 }, 0.0)]
        [TestCase(new int[] { 1, -6, -7 }, 64.0)]
        [TestCase(new int[] { 1, -2, 1 }, 0.0)]
        public void GetDiscrTest(int[] arr, double expected)
        {
            //arrange

            //act
            double actual = _hw.GetDiscr(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, -2, -24 }, 100.0, new double[] { 6.0, -4.0 })]
        [TestCase(new int[] { 3, -18, 27 }, 0, new double[] { 3.0 })]
        public void CalculateXTest(int[] arr, double discr, double[] expected)
        //public void CalculateXTest()
        {
            //arrange
            //int[] arr = new int[] { 1, -2, -24};
            //double discr = 100;
            //double[] expected = {6.0, -4.0};
            //act
            double[] actual = _hw.CalculateX(arr, discr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(11, "одиннадцать")]
        [TestCase(22, "двадцать два")]
        [TestCase(12, "двенадцать")]
        [TestCase(99, "девяносто девять")]
        [TestCase(19, "девятнадцать")]
        [TestCase(22, "двадцать два")]
        public void GetNumInStringTest(int num, string expected)

        {
            //arrange

            //act
            string actual = _hw.GetNumInString(num);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(10,10,10,true)]
        [TestCase(10,10,100,false)]
        [TestCase(10.5,10.5,100,false)]
        [TestCase(10.5, 100.5, 10.5,false)]
        [TestCase(1, 2, 3,false)]
        [TestCase(1.5, 2, 3,true)]
        
        public void CanBeTriangleTest(double a, double b, double c, bool expected)

        {
            //arrange

            //act
            var actual = _hw.CanBeTriangle(a,b,c);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}