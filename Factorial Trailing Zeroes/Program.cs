using System;
///https://leetcode.com/problems/factorial-trailing-zeroes/

/*
Given an integer n, return the number of trailing zeroes in n!.

Example 1:

Input: 3
Output: 0
Explanation: 3! = 6, no trailing zero.
Example 2:

Input: 5
Output: 1
Explanation: 5! = 120, one trailing zero. 
*/
namespace Factorial_Trailing_Zeroes
{
    public static class AppHelper
    {
        public static Int32 TrailingZeroes(Int32 n)
        {
            return n == 0 ? 0 : n / 5 + TrailingZeroes(n / 5);
        }
    }
    public class Solution
    {
        public int TrailingZeroes(int n)
        {
            return AppHelper.TrailingZeroes(n);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
