using System;
using System.Linq;

//https://leetcode.com/problems/height-checker/
/*
Input: heights = [1,1,4,2,1,3]
Output: 3
Explanation: 
Current array : [1,1,4,2,1,3]
Target array  : [1,1,1,2,3,4]
On index 2 (0-based) we have 4 vs 1 so we have to move this student.
On index 4 (0-based) we have 1 vs 3 so we have to move this student.
On index 5 (0-based) we have 3 vs 4 so we have to move this student.
Example 2:

Input: heights = [5,1,2,3,4]
Output: 5
Example 3:

Input: heights = [1,2,3,4,5]
Output: 0
*/
namespace Height_Checker
{
    public static class AppHelper
    {
        public static Int32 HeightChecker(Int32[] heights)
        {
            Int32[] newarr = heights.OrderBy(x => x).ToArray();
            Int32 count = 0;
            for (Int32 i = 0; i < newarr.Length; i++)
            {
                if (newarr[i] != heights[i])
                    count++;
            }
            return count;
        }
    }

    public class Solution
    {
        public int HeightChecker(int[] heights)
        {
            return AppHelper.HeightChecker(heights);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
