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
            int[] numbers = { 5 , 8 , 12 , 19 , 22 };
            Assert.AreEqual( 13 , Kata.SumTwoSmallestNumbers( numbers ) );
        }
    }
}