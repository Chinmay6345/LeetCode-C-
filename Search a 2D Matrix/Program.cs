using System;

namespace Search_a_2D_Matrix
{
    //https://leetcode.com/problems/search-a-2d-matrix
    public static class AppHelper
    {
        public static bool SearchMatrix(int[][] matrix, int target)
        {
            int currentrow = 0;
            int col = matrix[0].Length - 1;
            int noOfRows = matrix.Length - 1;
            while (currentrow <= noOfRows && col >= 0)
            {
                if (matrix[currentrow][col] > target)
                    col--;
                else if (matrix[currentrow][col] < target)
                    currentrow++;
                else if (matrix[currentrow][col] == target)
                    return true;

            }
            return false;
        }
    }


    public class Solution
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            return AppHelper.SearchMatrix(matrix, target);
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
