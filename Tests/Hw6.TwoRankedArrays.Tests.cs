using NUnit.Framework;
using MyMethods;
using System;
namespace Tests
{
    public class Hw6Tests
    {
        Hw6 _hw;
        [SetUp]
        public void Setup()
        {
            _hw = new Hw6();
        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(-1)]
        public void GetMinFromArrTest(int arrayIndex)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForChangeSignTest(arrayIndex);
            int[,] expected = TestData.GetAnswerForChangeSignTest(arrayIndex);

            //act
            _hw.ChangeSign(arrayToTest);
            //assert
            Assert.AreEqual(expected, arrayToTest);
        }
        [Test]
        public void GetMultiMatrixTest()
        {
            //arrange
            
            int[,] expected = {
                { 1,2,3,4,5,6,7,8,9,},
                { 2,4,6,8,10,12,14,16,18,},
                { 3,6,9,12,15,18,21,24,27,},
                { 4,8,12,16,20,24,28,32,36,},
                { 5,10,15,20,25,30,35,40,45,},
                { 6,12,18,24,30,36,42,48,54,},
                { 7,14,21,28,35,42,49,56,63,},
                { 8,16,24,32,40,48,56,64,72,},
                { 9,18,27,36,45,54,63,72,81,}
            };

            //act
            var actual = _hw.GetMultiMatrix();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(5)]
        [TestCase(-1)]
        public void GetChessDescTest(int n)
        {
            //arrange
            var expected = TestData.GetArrayChessDescTest(n);
            //act
            var actual = _hw.GetChessDesc(n);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, true)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        [TestCase(5, false)]
        [TestCase(-1, true)]
        public void CheckCovidTest(int n, bool expected)
        {
            //arrange
            var acatualCase = TestData.GetArrayForCheckCovidTest(n);
            //act
            var actual = _hw.CheckCovid(acatualCase);
            //assert
            Assert.AreEqual(expected, actual);
        }
        //shops
        //прибыль каждого за 6 месяцев (4 магазина)
        [TestCase(1, new double[] { 0, 0, 0, 0 })]
        [TestCase(2, new double[] { 1, 1, 1, 1 })]
        [TestCase(3, new double[] { 6.6, 6.6, 6.6, 6.6 })]
        [TestCase(4, new double[] { 0, 0, 0, })]
        [TestCase(-1, new double[] { 0 })]
        public void GetIncomeEveryShopTest(int n, double[] expected)
        {
            //arrange
            var acatualCase = TestData.GetArrayShopsTest(n);
            //act
            var actual = _hw.GetIncomeEveryShop(acatualCase);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, new double[] { 0, 0, 0, 0 })]
        [TestCase(2, new double[] { 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6 })]
        //[TestCase(3, new double[] { 1.1, 1.1, 1.1, 1.1 })] //не знаю как сравнить число 1.1000000000001 и 1.09999999999
        [TestCase(3, new double[] { 6.6 / 6, 6.6 / 6, 6.6 / 6, 6.6 / 6 })] //не знаю как сравнить число 1.1000000000001 и 1.09999999999
        [TestCase(4, new double[] { 0, 0, 0 })]
        [TestCase(-1, new double[] { 0 })]
        //средний доход магазина
        public void GetAveregeForShopTest(int n, double[] expected)
        {
            //arrange
            var acatualCase = TestData.GetArrayShopsTest(n);
            //act
            var actual = _hw.GetAveregeForShop(acatualCase);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 3)] 
        [TestCase(4, 4)]
        [TestCase(-1, -1)]
        //мин и макс доход каждого магазина
        public void GetMinMaxForShopTest(int n, int expected)
        {
            //arrange
            var acatualCase = TestData.GetArrayShopsTest(n);
            var expectedArr = TestData.GetArrayMinMaxForShopTest(expected);
            //act
            var actual = _hw.GetMinMaxForShop(acatualCase);
            //assert
            Assert.AreEqual(expectedArr, actual);
        }
        [TestCase(0, 5)]
        [TestCase(1, 0)]
        [TestCase(2, 9)]
        [TestCase(3, 4)]
        [TestCase(4, 0)]
        [TestCase(5, 0)]
        [TestCase(6, 12)]
        public void CountOfBiggersTest(int arrayIndex, int expected)
        {
            //arrange
            int[,] arrayToTest = TestData.GetArrayForCountOfBiggersTest(arrayIndex);

            //act
            int actual = _hw.CountOfBiggers(arrayToTest);
            //assert
            Assert.AreEqual(expected, actual);
        }
        

        [TestCase(7)] // по заданию 7х7
        public void MakeABytePictureTest(int SizeOfSideSquare)
        {
            //arrange
            char[,] expected = { 
                { '1','1','1','1','1','1','1',}, 
                { '0','1','1','1','1','1','0',}, 
                { '0','0','1','1','1','0','0',}, 
                { '0','0','0','1','0','0','0',}, 
                { '0','0','1','1','1','0','0',}, 
                { '0','1','1','1','1','1','0',}, 
                { '1','1','1','1','1','1','1',}, 
            };

            //act
            byte[,] actual = _hw.MakeABytePicture(SizeOfSideSquare);
            //assert
            Assert.AreEqual(expected, _hw.ConvertBytePicToChars(actual));
        }
        //умножение матриц
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void MultiplexMatrixTest(int indexOfArgs)
        {
            //arrange
            var firstMatrixToMulty = TestData.GetArrayMultiThirstTest(indexOfArgs);
            var secondMatrixToMulty = TestData.GetArrayMultiSecondTest(indexOfArgs);

            var expected = TestData.GetArrayMultiAnswerTest(indexOfArgs);
            //act
            var actual = _hw.MultiplexMatrix(firstMatrixToMulty, secondMatrixToMulty);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(5, "невозможно перемножить входные матрицы!\n")]
        //умножение матриц негатив
        public void MultiplexMatrixNegativeTest(int indexOfArgs, string expected)
        {
            //arrange
            var firstMatrixToMulty = TestData.GetArrayMultiThirstTest(indexOfArgs);
            var secondMatrixToMulty = TestData.GetArrayMultiSecondTest(indexOfArgs);

            //act 

            //assert
            Exception ex = Assert.Throws(typeof(ArgumentException), 
                () => _hw.MultiplexMatrix(firstMatrixToMulty, secondMatrixToMulty));
            Assert.AreEqual(expected, ex.Message);
        }
    }
}