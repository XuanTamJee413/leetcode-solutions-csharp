using Leetcode.Easy;

Console.WriteLine("<<< LeetCode Test Runner >>>");

int[] nums = { 2, 7, 11, 15 };
int target = 9;

var solver = new TwoSumSln();
var result = solver.TwoSum(nums, target);

Console.WriteLine($"TwoSum: [{result[0]}, {result[1]}]");