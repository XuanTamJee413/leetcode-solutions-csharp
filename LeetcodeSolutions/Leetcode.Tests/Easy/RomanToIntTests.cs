using Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests.Easy
{
    public class RomanToIntTests
    {
        [Theory]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("IX", 9)]
        [InlineData("LVIII", 58)]       // L = 50, V = 5, III = 3
        [InlineData("MCMXCIV", 1994)]   // M = 1000, CM = 900, XC = 90, IV = 4
        [InlineData("XL", 40)]
        [InlineData("XC", 90)]
        [InlineData("CD", 400)]
        [InlineData("CM", 900)]
        [InlineData("MMXXV", 2025)]
        [InlineData("MMMCMXCIX", 3999)] // max
        [InlineData("I", 1)]            // min

        public void RomanToInt_TestCases(string input, int expected)
        {
            var solution = new RomanToIntSln();
            var result = solution.RomanToInt(input);
            Assert.Equal(expected, result);
        }
    }
}
