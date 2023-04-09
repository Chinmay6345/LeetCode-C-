using System;
using System.Linq;
using System.Collections.Generic;


namespace _994_Rotting_Oranges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[][] { new int[] { 2, 1,1 }, new int[] { 1,1,0 }, new int[] { 0,1,1, } };
            Console.WriteLine(AppHelper.OrangesRotting(grid));
            Console.ReadLine();
        }
    }

    public class Solution
    {
        public int OrangesRotting(int[][] grid)
        {
            return AppHelper.OrangesRotting(grid);
        }
    }

    public static class AppHelper
    {
        public static int OrangesRotting(int[][] grid)
        {
            int time = 0;
            int fresh = 0;
            int noOfRows = grid.Length;
            int noOfCols = grid[0].Length;
            Queue<(int R, int C)> queue = new Queue<(int R, int C)>();
            for (int row = 0; row < noOfRows; row++)
            {
                for (int col = 0; col < noOfCols; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        fresh += 1;
                    }
                    if (grid[row][col] == 2)
                    {
                        queue.Enqueue((row, col));
                    }
                }
            }

            int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 } };
            while (queue.Count > 0 && fresh > 0)
            {
                for (int i = 0; i < queue.Count(); i++)
                {
                    var row_col = queue.Dequeue();
                    foreach (int[] direction in directions)
                    {
                        int currRow = direction[0] + row_col.R;
                        int currCol = direction[1] + row_col.C;
                        if (currRow < 0 || currRow == grid.Length || currCol < 0 || currCol == grid[0].Length || grid[currRow][currCol] != 1)
                        {
                            continue;
                        }

                        grid[currRow][currCol] = 2;
                        queue.Enqueue((currRow, currCol));
                        fresh -= 1;
                    }
                }
                time += 1;
            }
            return fresh == 0 ? time : -1;
        }
    }
}
