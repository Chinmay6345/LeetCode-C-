using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://leetcode.com/problems/check-if-move-is-legal/

namespace _1958.Check_if_Move_is_Legal
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public bool CheckMove(char[][] board, int rMove, int cMove, char color)
        {
            int rows = board.Length;
            int cols = board[0].Length;
            int[][] directions = new int[][] { new int[] { 0, 1 }, new int[] { 0, -1 }, new int[] { 1, 0 }, new int[] { -1, 0 },
                                               new int[] { 1, 1 }, new int[] { -1, -1 }, new int[] { 1, -1 }, new int[] { -1, 1 } };

            board[rMove][cMove] = color;

            foreach (var dir in directions)
            {
                if (legal(rMove, cMove, color, dir, board))
                {
                    return true;
                }
            }
            return false;
        }
        private bool legal(int row, int col, int color, int[] direction, char[][] board)
        {
            int rows = board.Length;
            int cols = board[0].Length;
            int newRow = row + direction[0];
            int newCol = col + direction[1];
            int len = 1;
            while (inBoard(board, newRow, newCol))
            {
                len += 1;
                if (board[newRow][newCol] == '.')
                {
                    return false;
                }
                if (board[newRow][newCol] == color)
                {
                    return len >= 3;
                }
                newRow = newRow + direction[0];
                newCol = newCol + direction[1];

            }
            return false;
        }
        private bool inBoard(char[][] board, int x, int y)
        {
            int rows = board.Length;
            int cols = board[0].Length;
            return x >= 0 && x < rows && y >= 0 && y < cols;
        }
    }
}
