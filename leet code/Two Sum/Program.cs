using System;
//https://leetcode.com/problems/two-sum/
/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.

Example:

Given nums = [2, 7, 11, 15], target = 9,

Because nums[0] + nums[1] = 2 + 7 = 9,
return [0, 1]. 
*/
namespace Two_Sum
{
    public static class AppHelper
    {
        public static Int32[] BruteForceTSum(Int32[] ints, Int32 target)
        {
            try
            {
                for (Int32 i = 0; i < ints.Length - 1; i++)
                {
                    for (Int32 j = i + 1; j < ints.Length; j++)
                    {
                        if (ints[i] + ints[j] == target)
                            return new Int32[] { i, j };
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            return new Int32[] { };
        }
    }
    public class Solution
    {
        public Int32[] TwoSum(int[] nums, int target)
        {
            try
            {
                return AppHelper.BruteForceTSum(nums, target);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException.ToString());
            }
            return new Int32[] { };
        }
    }
}
