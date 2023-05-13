using System;

namespace _867_Transpose_Matrix
{
    //https://leetcode.com/problems/transpose-matrix/

   public static class AppHelper
    {
        public static int[][] Transpose(int[][] matrix)
        {
            int[][] B = new int[matrix[0].Length][];
            Console.WriteLine(matrix[0].Length + " rows" + matrix.Length);
            for (int i = 0; i < matrix[0].Length; i++)
                B[i] = new int[matrix.Length];
            for (int i = 0; i < matrix.Length; i++)
                for (int j = 0; j < matrix[0].Length; j++)
                    B[j][i] = matrix[i][j];
            return B;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = { new int [] { 1, 2, 3 },new int []{ 4, 5, 6 },new int []{ 7, 8, 9 } };
            var a = AppHelper.Transpose(matrix);
            Console.ReadLine();
        }
    }
}
