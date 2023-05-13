using System;

namespace Subarray_Sum_Equals_K
{
    //https://leetcode.com/problems/subarray-sum-equals-k/
    public static class AppHelper
    {
        public static Int32 Subarraysum(Int32[] nums, Int32 sum)
        {
            var dic = new System.Collections.Generic.Dictionary<int, int>();
            int k = sum;
            int count = 0;
            int psum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                psum += nums[i];

                if (psum == k) count++;

                if (dic.ContainsKey(psum - k))
                {

                    count += dic[psum - k];
                }

                if (!dic.ContainsKey(psum))
                {
                    dic.Add(psum, 1);
                }
                else
                {
                    dic[psum] = dic[psum] + 1;
                }
            }
            return count;
        }
    }



    public class Solution
    {
        public int SubarraySum(int[] nums, int k)
        {
            return AppHelper.Subarraysum(nums, k);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
