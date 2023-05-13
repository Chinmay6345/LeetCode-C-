using System;
using System.Collections.Generic;

namespace _85._Maximal_Rectangle
{
    public static class Solution
    {
        public static int MaximalRectangle(char[][] matrix)
        {
            if (matrix == null || matrix.Length == 0) return 0;
            int m = matrix.Length;
            int n = matrix[0].Length;
            int max = 0;

            // we can solve this problem with problem 84
            // make it line by line
            var heights = new int[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i][j] == '0')
                    {
                        heights[j] = 0; // reset, start from 0 again
                    }
                    else
                    {
                        heights[j]++;
                    }
                }

                max = Math.Max(max, LargestRectangle(heights));
            }

            return max;
        }

        private static int LargestRectangle(int[] heights)
        {
            var stack = new Stack<int>(); // keep increasing stack with index in it
            int len = heights.Length;
            int index = 0;
            int maxArea = 0;

            while (index < len)
            {
                
                if (stack.Count == 0 || heights[stack.Peek()] <= heights[index])
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(heights[stack.Peek()] + " " + heights[index]);
                    }
                    stack.Push(index);
                    index++;
                }
                else
                {
                    // start processing the smallest bar
                    var tp = stack.Pop();
                    var area = heights[tp] * (stack.Count == 0 ? index : (index - stack.Peek() - 1));
                    maxArea = Math.Max(maxArea, area);
                }
            }

            while (stack.Count > 0)
            {
                var tp = stack.Pop();
                var area = heights[tp] * (stack.Count == 0 ? index : (index - stack.Peek() - 1));
                maxArea = Math.Max(maxArea, area);
            }

            return maxArea;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            char[][] matrix = new char[][]
            {
               new char []{'1', '0', '1', '0', '0' },
               new char []{'1', '0', '1', '1', '1' },
               new char []{'1', '1', '1', '1', '1' },
               new char []{'1', '0', '0', '1', '0'}
            };
            int k= Solution.MaximalRectangle(matrix);
            Console.ReadLine();
        }
    }
}
