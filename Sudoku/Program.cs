using System;
using System.Linq;
using System.Collections.Generic;
namespace Sudoku
{
    public static class AppHelper
    {
        public static bool isSafe(ref int[][] board, int row, int col, int num)
        {

            for (int d = 0; d < board.Length; d++)
            {

                if (board[row][d] == num)
                {
                    return false;
                }
            }

            for (int r = 0; r < board.Length; r++)
            {

                if (board[r][col] == num)
                {
                    return false;
                }
            }
            int sqrt = (int)Math.Sqrt(board.Length);
            int boxRowStart = row - row % sqrt;
            int boxColStart = col - col % sqrt;

            for (int r = boxRowStart; r < boxRowStart + sqrt; r++)
            {
                for (int d = boxColStart; d < boxColStart + sqrt; d++)
                {
                    if (board[r][d] == num)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool solveSudoku(ref int[][] board, int n)
        {
            int row = -1;
            int col = -1;
            bool isEmpty = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == 0)
                    {
                        row = i;
                        col = j;
                        isEmpty = false;
                        break;
                    }
                }
                if (!isEmpty)
                {
                    break;
                }
            }

            if (isEmpty)
            {
                return true;
            }

            for (int num = 1; num <= n; num++)
            {
                if (isSafe(ref board, row, col, num))
                {
                    board[row][col] = num;
                    if (solveSudoku(ref board, n))
                    {
                        // print(board, n); 
                        return true;
                    }
                    else
                    {
                        // replace it 
                        board[row][col] = 0;
                    }
                }
            }
            return false;
        }
    }

    public static class P1
    {

        public static List<List<int>> SolveSudoku(List<List<int>> board)
        {
            var s = board.Select(g => g.ToArray()).ToArray();
            int N = s.Length;
            if (AppHelper.solveSudoku(ref s, N))
            {
                var p = s.Select(g => g.ToList()).ToList();
                return p;
            }
            return new List<List<int>>();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}
