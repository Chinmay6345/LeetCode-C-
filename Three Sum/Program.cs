using System;
using System.Collections.Generic;
using System.Linq;

namespace Three_Sum
{
    //https://leetcode.com/problems/3sum/
    public static class Solution
    {
        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            var result = new List<IList<int>>();
            nums = nums.OrderBy(g => g).ToArray<Int32>();
            int n = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if(i>0 && nums[i]==nums[i-1])
                {
                    continue;
                }
                int left = i + 1;
                int right = nums.Length - 1;
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[left], nums[right] });
                        while (left < right && nums[left] == nums[left + 1]) left++;
                        while (left < right && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum < 0)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }

                }
            }
            return result;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { -2,0,0,2,2 };
            var result = Solution.ThreeSum(arr);
            Console.ReadLine();
        }
    }
}
