using System;
using System.Linq;

//https://leetcode.com/problems/count-negative-numbers-in-a-sorted-matrix/

namespace Count_Negative_Numbers_in_a_Sorted_Matrix
{
    public static class AppHelper
    {
        public static Int32 CountNeg(Int32[][] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                count = count + Array.FindAll(arr[i], x => x < 0).Count();
            }
            return count;
        }
    }


    public class Solution
    {
        public int CountNegatives(int[][] grid)
        {
            return AppHelper.CountNeg(grid);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
