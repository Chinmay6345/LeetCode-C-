using System;
using System.Collections.Generic;
//https://leetcode.com/problems/intersection-of-two-arrays-ii/
/*
Given two arrays, write a function to compute their intersection.

Example 1:

Input: nums1 = [1,2,2,1], nums2 = [2,2]
Output: [2,2]
Example 2:

Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
Output: [4,9]
Note:

Each element in the result should appear as many times as it shows in both arrays.
The result can be in any order.
Follow up:

What if the given array is already sorted? How would you optimize your algorithm?
What if nums1's size is small compared to nums2's size? Which algorithm is better?
What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once? 
*/

namespace Intersection_of_Two_Arrays_II
{
    public static class AppHelper
    {
        public static Int32[] Intersect(Int32[] nums1, Int32[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<Int32> result = new List<Int32>();
            Int32 first = 0, second = 0;
            while (first < nums1.Length && second < nums2.Length)
            {
                if (nums1[first] == nums2[second])
                {
                    result.Add(nums1[first]);
                    first = first + 1;
                    second = second + 1;
                }
                else if (nums1[first] < nums2[second])
                    first = first + 1;
                else
                    second = second + 1;
            }
            return result.ToArray();
        }
    }
    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            return AppHelper.Intersect(nums1, nums2);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
