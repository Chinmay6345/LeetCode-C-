using System;

namespace N_Queens
{
    public static class AppHelper
    {
        public static int getNoOfNonAttackingQueens(int row, int[] columnPlacements, int bsize)
        {
            if (row == bsize)
                return 1;
            int count = 0;
            for (int col = 0; col < bsize; col++)
            {
                if (nonattack(row, col, columnPlacements))
                {
                    columnPlacements[row] = col;
                    count += getNoOfNonAttackingQueens(row + 1, columnPlacements, bsize);
                }
            }
            return count;
        }


        public static bool nonattack(int row, int col, int[] p)
        {
            for (int i = 0; i < row; i++)
            {
                int c = p[i];
                bool samecolumn = (c == col);
                bool diag = Math.Abs(c - col) == (row - i);
                if (diag || samecolumn)
                    return false;
            }
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
