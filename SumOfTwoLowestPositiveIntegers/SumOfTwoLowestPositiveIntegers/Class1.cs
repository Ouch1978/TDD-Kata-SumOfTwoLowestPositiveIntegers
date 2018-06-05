using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoLowestPositiveIntegers
{
    public static class Kata
    {
        public static int SumTwoSmallestNumbers( double[] numbers )
        {
            return numbers.Where( n => n > 0 && n <= int.MaxValue ).OrderBy( n => n ).Select( n => (int) n ).Take( 2 ).Sum();
        }
    }
}
