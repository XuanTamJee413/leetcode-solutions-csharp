using Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests.Easy
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void TwoSum_TestCases(int[] nums, int target, int[] expected)
        {
            var solution = new TwoSumSln();
            var result = solution.TwoSum(nums, target);
            Assert.Equal(expected, result);
        }
    }
}
