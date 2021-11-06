using NUnit.Framework;
using Core;

namespace Tests
{
    public class HelperTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(1, 2, 2, 1)]
        [TestCase(1.1, 2.2, 2.2, 1.1)]
        [TestCase("str1", "str2", "str2", "str1")]
        [TestCase(true, false, false, true)]
        [TestCase('a', 'b', 'b', 'a')]

        public void MySwapTest<T>(ref T a, ref T b, T expected1, T expected2)
        {
            
            Helper.MySwap(ref a, ref b);
            var actual1 = a;
            var actual2 = b;
            Assert.AreEqual(actual1, expected1);
            Assert.AreEqual(actual2, expected2);
        }
        [TestCase(2, 2, 1, new int[] { 1,2,2 })]
        [TestCase(3, 2, 1, new int[] { 1,2,3 })]
        [TestCase(1, 0, -1, new int[] { -1,0,1 })]
        [TestCase(-1, -2, -3, new int[] { -3,-2,-1 })]
        
        public void MyBubbleSortTest(int a, int b, int c, int[] expected)
        {

            var actual = Helper.MyBubbleSort(a,b,c);
            Assert.AreEqual(actual, expected);
        }
    }
}