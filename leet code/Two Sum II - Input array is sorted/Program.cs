using System;
using System.Collections.Generic;

//https://leetcode.com/problems/two-sum-ii-input-array-is-sorted/

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
