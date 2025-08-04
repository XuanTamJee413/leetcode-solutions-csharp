using Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests.Easy
{
    public class PalindromeTests
    {
        [Theory]
        [InlineData(121, true)]
        [InlineData(-121, false)]
        [InlineData(10, false)]
        [InlineData(0, true)]
        [InlineData(1, true)]
        [InlineData(22, true)]
        [InlineData(12321, true)]
        [InlineData(123321, true)]
        [InlineData(1000021, false)]
        [InlineData(1001, true)]
        [InlineData(100, false)]
        [InlineData(2147447412, true)]

        public void IsPalindrome_TestCases(int input, bool expected)
        {
            var solution = new PalindromeSln();
            var result = solution.IsPalindrome(input);
            Assert.Equal(expected, result);
        }
    }
}
