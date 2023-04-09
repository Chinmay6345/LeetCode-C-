using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/flipping-an-image/
namespace Flipping_an_Image
{
    public static class AppHelper
    {
        public static Int32[][] FlippedImage(Int32[][] jaggedArray3)
        {
            List<List<Int32>> lst = new List<List<int>>();
            foreach (var array in jaggedArray3)
            {
                lst.Add(array.Reverse().ToList());
            }
            Int32 count = 0;
            Int32[][] A = new Int32[jaggedArray3.Length][];
            List<int> newlst = new List<int>();
            foreach (var list in lst)
            {
                for (Int32 i = 0; i < list.Count; i++)
                {
                    Int32 k = list[i] == 1 ? 0 : 1;
                    newlst.Add(k);
                }
                A[count] = newlst.ToArray();
                count++;
                newlst = new List<int>();
            }
            return A;
        }
    }
    public class Solution
    {
        public int[][] FlipAndInvertImage(int[][] A)
        {
            return AppHelper.FlippedImage(A);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
