using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/spiral-matrix-iii/

namespace _885.Spiral_Matrix_III
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Solution
    {
        public int idx;

        private void add(int r, int c, int R, int C, int[][] ret)
        {
            if (r >= R || r < 0 || c >= C || c < 0) return;
            ret[idx][0] = r;
            ret[idx++][1] = c;
        }
        public int[][] SpiralMatrixIII(int rows, int cols, int rStart, int cStart)
        {
            int r = rStart, c = cStart, len = 1;
            int R = rows;
            int C = cols;
            int total = R * C;
            int[][] ret = new int[R * C][];
            for (int i = 0; i < total; i++)
            {
                ret[i] = new int[2];
            }
            while (idx < total)
            {
                for (int k = 0; k < len; k++) add(r, c++, R, C, ret);
                for (int k = 0; k < len; k++) add(r++, c, R, C, ret);
                len++;
                for (int k = 0; k < len; k++) add(r, c--, R, C, ret);
                for (int k = 0; k < len; k++) add(r--, c, R, C, ret);
                len++;
            }
            return ret;
        }
    }

}
