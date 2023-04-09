using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/sort-colors/
/*
Given an array with n objects colored red, white or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white and blue.

Here, we will use the integers 0, 1, and 2 to represent the color red, white, and blue respectively.

Note: You are not suppose to use the library's sort function for this problem.

Example:

Input: [2,0,2,1,1,0]
Output: [0,0,1,1,2,2] 
*/
namespace Sort_colors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            Array.Sort<int>(nums, new Comparison<int>(
                       (i1, i2) => i1.CompareTo(i2)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.SortColors(new int[] {2,0,2,1,1,0 });
        }
    }
}
