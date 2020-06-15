using System;
using System.Collections.Generic;
//https://leetcode.com/problems/transpose-matrix/
namespace Transpose_Matrix
{
    public static class AppHelper
    {
        public static Int32[][] Transpose(Int32[][] a)
        {
            Int32[][] b = new Int32[a[0].Length][];
            Int32 p = 0;
            Int32 x = 0, r = 0;
            List<Int32> lst = new List<Int32>();
            for (Int32 k = 0; k < a[0].Length; k++)
            {
                x = k;
                r = a.Length;
                while (r > 0)
                {
                    var s = a[p];
                    lst.Add(s[x]);
                    r--;
                    p++;
                }
                p = 0;
                b[k] = lst.ToArray();
                lst.Clear();
            }
            return b;
        }
    }
    public class Solution
    {
        public int[][] Transpose(int[][] A)
        {
            return AppHelper.Transpose(A);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
