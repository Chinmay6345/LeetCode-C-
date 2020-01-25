using System;
//https://leetcode.com/problems/maximum-subarray/
namespace Maximum_Subarray
{
    public static class Solution
    {
        public static int MaxSubArray(int[] nums)
        {
            int localmax = 0;
            int globalMax = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                localmax = Math.Max(nums[i], nums[i] + localmax);
                if (localmax > globalMax)
                {
                    globalMax = localmax;
                }
            }
            return globalMax;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int k = Solution.MaxSubArray(new Int32[] { 2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.ReadLine();
        }
    }
}
