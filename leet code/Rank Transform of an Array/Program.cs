using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/rank-transform-of-an-array/
/*
Given an array of integers arr, replace each element with its rank.

The rank represents how large the element is. The rank has the following rules:

Rank is an integer starting from 1.
The larger the element, the larger the rank. If two elements are equal, their rank must be the same.
Rank should be as small as possible.
 

Example 1:

Input: arr = [40,10,20,30]
Output: [4,1,2,3]
Explanation: 40 is the largest element. 10 is the smallest. 20 is the second smallest. 30 is the third smallest.
*/
namespace Rank_Transform_of_an_Array
{
    public static class AppHelper
    {
        public static Int32[] RankTransform(Int32[] arr)
        {
            List<int> nums = arr.ToList();
            Array.Sort(arr);
            Dictionary<Int32, Int32> HMap = new Dictionary<Int32, Int32>();
            int count = 0;
            for (Int32 i = 0; i < arr.Length; i++)
            {
                if (!HMap.ContainsKey(arr[i]))
                {
                    count++;
                    HMap.Add(arr[i], count);
                }
            }
            for (int i = 0; i < nums.Count; i++)
            {
                nums[i] = HMap[nums[i]];
            }
            return nums.ToArray();
        }
    }
    public class Solution
    {
        public int[] ArrayRankTransform(int[] arr)
        {
            return AppHelper.RankTransform(arr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
