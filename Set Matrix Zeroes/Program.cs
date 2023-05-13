using System;
using System.Text;
namespace Set_Matrix_Zeroes
{
    //https://leetcode.com/problems/set-matrix-zeroes/

    public static class AppHelper
    {
        public static void SetZeroes(ref int[][] matrix)
        {
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        Mark(ref matrix, i, j);
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i][j] ==-1)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
        public static void Mark(ref int[][] matrix, int row, int col)
        {
            int rows = matrix.Length;
            int columns = matrix[0].Length;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i][col] != 0)
                {
                    matrix[i][col] = -1;
                }
            }
            for (int j = 0; j < columns; j++)
            {
                if (matrix[row][j] != 0)
                {
                    matrix[row][j] = -1;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = { new int[] { 1,1,1 }, new int[] {1,0,1 }, new int[] { 1, 1, 1 } };
            AppHelper.SetZeroes(ref matrix);
            int k = 1;
            Console.ReadLine();
        }
    }
}
