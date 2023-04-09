using System;
//https://leetcode.com/problems/find-n-unique-integers-sum-up-to-zero/

/*
Input: n = 5
Output: [-7,-1,1,3,4]
Explanation: These arrays also are accepted [-5,-1,1,2,3] , [-3,-1,2,-2,4].
Example 2:

Input: n = 3
Output: [-1,0,1]
Example 3:

Input: n = 1
Output: [0] 
*/

namespace Find_N_Unique_Integers_Sum_up_to_Zero
{
    public static class AppHelper
    {
        public static Int32[] NUniqueIntegers(Int32 n)
        {
            Int32[] arr = new Int32[n];
            for (Int32 i = 0; i < n; i++)
            {
                arr[i] = i * 2 - n + 1;
            }
            return arr;
        }
    }
    public class Solution
    {
        public int[] SumZero(int n)
        {
            return AppHelper.NUniqueIntegers(n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
