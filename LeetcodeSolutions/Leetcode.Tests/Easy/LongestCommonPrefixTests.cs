using Leetcode.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Tests.Easy
{
    public class LongestCommonPrefixTests
    {
        [Theory]
        [InlineData(new[] { "flower", "flow", "flight" }, "fl")]
        [InlineData(new[] { "dog", "racecar", "car" }, "")]
        [InlineData(new[] { "interspecies", "interstellar", "interstate" }, "inters")]
        [InlineData(new[] { "a" }, "a")]
        [InlineData(new[] { "ab", "a" }, "a")]
        [InlineData(new[] { "ab", "bc" }, "")]
        [InlineData(new[] { "", "" }, "")]
        [InlineData(new[] { "prefix", "prefixes" }, "prefix")]
        public void LongestCommonPrefix_ReturnsExpected(string[] input, string expected)
        {
            var solution = new LongestCommonPrefixSln();
            var result = solution.LongestCommonPrefix(input);
            Assert.Equal(expected, result);
        }
    }
}
