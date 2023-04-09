using System;
using System.Collections.Generic;
//https://leetcode.com/problems/decompress-run-length-encoded-list/
/*
We are given a list nums of integers representing a list compressed with run-length encoding.

Consider each adjacent pair of elements [freq, val] = [nums[2*i], nums[2*i+1]] (with i >= 0).  For each such pair, there are freq elements with value val concatenated in a sublist. Concatenate all the sublists from left to right to generate the decompressed list.

Return the decompressed list.

 

Example 1:

Input: nums = [1,2,3,4]
Output: [2,4,4,4]
Explanation: The first pair [1,2] means we have freq = 1 and val = 2 so we generate the array [2].
The second pair [3,4] means we have freq = 3 and val = 4 so we generate [4,4,4].
At the end the concatenation [2] + [4,4,4] is [2,4,4,4]. 
*/
namespace Decompress_Run_Length_Encoded_List
{
    public static class AppHelper
    {
        public static Int32[] Lst(Int32[] nums)
        {
            Int32 k = 0;
            List<Int32> lst = new List<Int32>();
            for (int i = 0; i < nums.Length; i++)
            {
                k = nums[i];
                i = i + 1;
                while (k > 0)
                {
                    lst.Add(nums[i]);
                    k = k - 1;
                }
            }
            return lst.ToArray();
        }
    }

    public class Solution
    {
        public int[] DecompressRLElist(int[] nums)
        {
            return AppHelper.Lst(nums);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
