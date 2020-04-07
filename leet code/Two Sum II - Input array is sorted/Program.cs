using System;
using System.Collections.Generic;

//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/
/*
Given an array of integers that is already sorted in ascending order, find two numbers such that they add up to a specific target number.

The function twoSum should return indices of the two numbers such that they add up to the target, where index1 must be less than index2.

Note:

Your returned answers (both index1 and index2) are not zero-based.
You may assume that each input would have exactly one solution and you may not use the same element twice.
Example:

Input: numbers = [2,7,11,15], target = 9
Output: [1,2]
Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2. 
*/
namespace Two_Sum_II___Input_array_is_sorted
{
    public static class AppHelper
    {
        public static Int32[] TSum(Int32[] arr, Int32 target)
        {
            try
            {
                Dictionary<Int32, Int32> HMap = new Dictionary<Int32, Int32>();
                Int32 i;
                Int32 compliment;
                for (i = 0; i < arr.Length; i++)
                {
                    compliment = target - arr[i];
                    if (HMap.ContainsKey(arr[i]))
                    {
                        return new Int32[] { HMap[arr[i]] + 1, i + 1 };
                    }
                    else if (!HMap.ContainsKey(compliment))
                    {
                        HMap.Add(compliment, i);
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
                return AppHelper.TSum(nums, target);
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
