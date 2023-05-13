using System;

namespace Rotate_Image
{
    class Program
    {
        static void Main(string [] args)
        {
            int[][] matrix =new int[][]{new int[]{1, 2, 3}, new int[] { 4, 5, 6}, new int[] { 7, 8, 9}};
            Array.Reverse(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int val = matrix[i][j];
                    Console.WriteLine(matrix[i][j] + " =" + matrix[j][i]);
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = val;
                }
            }
            Console.ReadLine();
        }
    }
}
