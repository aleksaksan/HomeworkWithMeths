using NUnit.Framework;
using MyMethods;

namespace Tests
{
    public class Hw5Tests
    {
        Hw5 _hw;
        [SetUp]
        public void Setup()
        {
            _hw = new Hw5();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 2, 2, 2, 5 }, 2)]
        [TestCase(new int[] { 1 }, 1)]
        [TestCase(new int[] { 2 }, 0)]

        public void GetAmountOddsTest(int[] val, int expected)

        {
            //arrange

            //act
            var actual = _hw.GetAmountOdds(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 2, 2, 2, 5 }, 3)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 0 }, 1)]

        public void GetAmountEvensTest(int[] val, int expected)

        {
            //arrange

            //act
            var actual = _hw.GetAmountEvens(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArrWithSumOfTwoNeighbElemsTest()
        {
            //arrange
            int[] actual = { 1, 2, 3, 4, 5, 6 };
            int[] actual1 = { 2, 2, 2, 3, 3, 3 };
            int[] actual2 = { 1, 1, 1, 1, 1, 1 };
            int[] expected = { 1, 2, 3, 4, 5, 9 };
            int[] expected1 = { 2, 2, 4, 3, 3, 6};
            int[] expected2 = { 1, 1, 2, 1, 1, 2 };
            //act
            _hw.GetArrWithSumOfTwoNeighbElems(actual);
            _hw.GetArrWithSumOfTwoNeighbElems(actual1);
            _hw.GetArrWithSumOfTwoNeighbElems(actual2);

            //assertd
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
        [TestCase(new int[] { 1, 2 }, new int[] { 3, 4, 5 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { }, new int[] { }, new int[] { })]
        [TestCase(new int[] { 1,1,1 }, new int[] { 2,2,2 }, new int[] { 1,1,1,2,2,2 })]
        [TestCase(new int[] { 1,1,1 }, new int[] { }, new int[] { 1,1,1 })]
        [TestCase(new int[] { }, new int[] { 1,1,1 }, new int[] { 1,1,1 })]

        public void MergeTwoArraysTest(int[] val, int[] arr, int[] expected)

        {
            //arrange

            //act
            var actual = _hw.MergeTwoArrays(val, arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 1, 1, 1 }, new int[] { 1, 1, 1, 1 })]

        public void ChangeHalvesTest(int[] arr, int[] expected)

        {
            //arrange

            //act
            var actual = _hw.ChangeHalves(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4 }, 1, new int[] { 4, 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4 }, 2, new int[] { 3, 4, 1, 2 })]
        [TestCase(new int[] { 1, 2 },3, new int[] { 2, 1 })]
        [TestCase(new int[] { }, 100, new int[] { })]
        [TestCase(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 },6, new int[] { 0, 0, 0, 0, 0, 0, 1, 0, 0 })]
        [TestCase(new int[] { 1, 0, 0, 0, 0, 0, 0, 0, 0 },1, new int[] { 0, 1, 0, 0, 0, 0, 0, 0, 0 })]

        public void SheeftLoopArrTest(int[] arr, int val, int[] expected)

        {
            //arrange

            //act
            var actual = _hw.SheeftLoopArr(arr, val);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 1, 4, 3, 5 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 1, 0, 0, 0 }, new int[] { 0, 1, 0, 0 })]
        [TestCase(new int[] { 1, 0, 0, 0, 0 }, new int[] { 0, 1, 0, 0, 0 })]
        [TestCase(new int[] { 1 }, new int[] { 1 })]

        public void SwapNeighbInArrTest(int[] arr, int[] expected)

        {
            //arrange

            //act
            var actual = _hw.SwapNeighbInArr(arr);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { -1, 2, 3, 4, 5 }, 1)]
        [TestCase(new int[] { }, -1)]
        [TestCase(new int[] { 1, 2, 2, 2, -5 }, 1)]
        [TestCase(new int[] { 1, -1, -2, -4 }, 1)]
        [TestCase(new int[] { -2, -1, 0 }, 0)]

        public void FindABSMinTest(int[] val, int expected)

        {
            //arrange

            //act
            var actual = _hw.FindABSMin(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { -1, 111, 0, 4, 5 }, 9)]
        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 1, 2, 2, 2, -5 }, 0)]
        [TestCase(new int[] { 0, -1, -2, -4 }, -7)]
        [TestCase(new int[] { -2, -1, 0 }, 0)]

        public void GetSumAfterZeroTest(int[] val, int expected)

        {
            //arrange

            //act
            var actual = _hw.GetSumAfterZero(val);
            //assert
            Assert.AreEqual(expected, actual);
        }
       
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new int[] { 6, 7, 8, 9, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 2, 1, 8, 5, 4, 3, 9, 7, 6 })]

        public void InsertSortTest(int[] arr)

        {
            //arrange
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //act
            _hw.InsertSort(arr);
            //assert
            Assert.AreEqual(arr, expected);
        }
        [TestCase(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 })]
        [TestCase(new int[] { 6, 7, 8, 9, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 2, 1, 8, 5, 4, 3, 9, 7, 6 })]

        public void SelectSortTest(int[] arr)

        {
            //arrange
            int[] expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //act
            _hw.SelectSort(arr);
            //assert
            Assert.AreEqual(arr, expected);
        }
    }
}