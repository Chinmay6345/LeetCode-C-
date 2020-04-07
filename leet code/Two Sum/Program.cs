using System;

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
