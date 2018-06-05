using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoLowestPositiveIntegers
{
    public static class Kata
    {
        public static double SumTwoSmallestNumbers( double[] numbers )
        {
            return numbers.Where( n => n > 0 ).OrderBy( n => n ).Take( 2 ).Sum();
        }
    }
}
