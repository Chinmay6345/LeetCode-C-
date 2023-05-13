using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1572.Matrix_Diagonal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int DiagonalSum(int[][] mat)
        {
            int m = mat.Length;
            int n = mat[0].Length;
            int sum = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        sum += mat[i][j];
                }
            }
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i + j) == (n - 1))
                        sum += mat[i][j];
                }
            }
            if (n % 2 == 1) sum -= mat[n / 2][n / 2];
            return sum;
        }
    }
}
