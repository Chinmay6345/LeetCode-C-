using System;
using System.Collections.Generic;
namespace Longest_subarray_with_given_sum
{
    public static class AppHelper
    {
        public static int longestSubarrayWithSum(int [] arr,int sum,int n)
        {
            int res = 0;
            Dictionary<int, int> map = new Dictionary<int, int>();
            int presum = 0;
            for(int i=0;i<n;i++)
            {
                presum += arr[i];
                if (presum == sum)
                    res = i + 1;
                if (!map.ContainsKey(presum - sum))
                    map.Add(presum, i);
                else
                    res = Math.Max(res, i - map[presum - sum]);
            }
            return res;
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
