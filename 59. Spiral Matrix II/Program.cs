using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/spiral-matrix-ii/

namespace _59.Spiral_Matrix_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(new Solution().GenerateMatrix(n));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int[][] GenerateMatrix(int n)
        {
            // Declaration
            int[][] matrix = new int[n][];
            for(int i=0;i<n;i++)
            {
                matrix[i] = new int[n];
            }
            // Edge Case
            if (n == 0)
            {
                return matrix;
            }

            // Normal Case
            int rowStart = 0;
            int rowEnd = n - 1;
            int colStart = 0;
            int colEnd = n - 1;
            int num = 1; //change

            while (rowStart <= rowEnd && colStart <= colEnd)
            {
                for (int i = colStart; i <= colEnd; i++)
                {
                    matrix[rowStart][i] = num++; //change
                }
                rowStart++;

                for (int i = rowStart; i <= rowEnd; i++)
                {
                    matrix[i][colEnd] = num++; //change
                }
                colEnd--;

                for (int i = colEnd; i >= colStart; i--)
                {
                    if (rowStart <= rowEnd)
                        matrix[rowEnd][i] = num++; //change
                }
                rowEnd--;

                for (int i = rowEnd; i >= rowStart; i--)
                {
                    if (colStart <= colEnd)
                        matrix[i][colStart] = num++; //change
                }
                colStart++;
            }

            return matrix;
        }

    }
}
