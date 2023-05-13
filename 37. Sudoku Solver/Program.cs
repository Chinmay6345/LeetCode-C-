using System;

namespace _37._Sudoku_Solver
{
    public static class AppHelper
    {
        public static bool solveSudoku(ref char[][] board)
        {
            int row = -1;
            int col = -1;
            int n = board.Length;
            bool isEmpty = true;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (board[i][j] == '.')
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
                if (isSafe(ref board, row, col, Convert.ToString(num)))
                {
                    board[row][col] = Convert.ToChar(num.ToString());
                    if (solveSudoku(ref board))
                    {
                        print(ref board, n); 
                        return true;
                    }
                    else
                    {
                        // replace it 
                        board[row][col] = '.';
                    }
                }
            }
            return false;
        }

        public static bool isSafe(ref char[][] board, int row, int col, String num)
        {
           
            for (int d = 0; d < board.Length; d++)
            {

                if (board[row][d] == Convert.ToChar(num))
                {
                    return false;
                }
            }

            for (int r = 0; r < board.Length; r++)
            {

                if (board[r][col] == Convert.ToChar(num))
                {
                    return false;
                }
            }
            int sqrt = (int)Math.Sqrt(board.Length);
            int boxRowStart = row - row % sqrt;
            int boxColStart = col - col % sqrt;

            for (int r = boxRowStart;r < boxRowStart + sqrt; r++)
            {
                for (int d = boxColStart;d < boxColStart + sqrt; d++)
                {
                    if (board[r][d] == Convert.ToChar(num))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static void print(ref char[][] board, int N)
        {
            for (int r = 0; r < N; r++)
            {
                for (int d = 0; d < N; d++)
                {
                    Console.Write(Convert.ToString(board[r][d]) + " ");
                }
                Console.WriteLine();

                if ((r + 1) % (int)Math.Sqrt(N) == 0)
                {
                    Console.Write(" ");
                }
            }
        }

    }

    internal class Program
    {
        static void Main(string [] args)
        {
            char[][] board = new char[][] {
                                          new char[]{'5', '3', '.', '.', '7', '.', '.', '.', '.'},
                                          new char[]{'6', '.', '.', '1', '9', '5', '.', '.', '.'},
                                          new char[]{'.', '9', '8', '.', '.', '.', '.', '6', '.'},
                                          new char[]{'8', '.', '.', '.', '6', '.', '.', '.', '3'},
                                          new char[]{'4', '.', '.', '8', '.', '3', '.', '.', '1'},
                                          new char[]{'7', '.', '.', '.', '2', '.', '.', '.', '6'},
                                          new char[]{'.', '6', '.', '.', '.', '.', '2', '8', '.'},
                                          new char[]{'.', '.', '.', '4', '1', '9', '.', '.', '5'},
                                          new char[]{'.', '.', '.', '.', '8', '.', '.', '7', '9'}
                                        };
            int N = board.Length;

            if (AppHelper.solveSudoku(ref board))
            {
                AppHelper.print(ref board, N);
            }
            else
            {
                //System.out.println("No solution");
            }
            Console.ReadLine();
        }
    }
}
