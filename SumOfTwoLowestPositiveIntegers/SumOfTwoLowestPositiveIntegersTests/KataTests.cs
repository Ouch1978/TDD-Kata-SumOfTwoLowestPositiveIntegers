using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOfTwoLowestPositiveIntegers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoLowestPositiveIntegers.Tests
{
    [TestClass()]
    public class KataTests
    {
        [TestMethod()]
        public void SumTwoSmallestNumbersTest()
        {
            double[] numbers = { 5 , 8 , 12 , 19 , 22 };
            Assert.AreEqual( 13 , Kata.SumTwoSmallestNumbers( numbers ) );
        }

        [TestMethod()]
        public void SumTwoSmallestNumbersTest2()
        {
            double[] numbers = { 10, 343445353, 3453445, 3453545353453 };
            Assert.AreEqual( 3453455 , Kata.SumTwoSmallestNumbers( numbers ) );
        }

        [TestMethod()]
        public void SumTwoSmallestNumbersTest3()
        {
            double[] numbers = { -10, 100, 5 , 1 };
            Assert.AreEqual( 6 , Kata.SumTwoSmallestNumbers( numbers ) );
        }
    }
}