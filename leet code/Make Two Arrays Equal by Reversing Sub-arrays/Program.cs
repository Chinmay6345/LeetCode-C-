using System;
using System.Linq;
//https://leetcode.com/problems/make-two-arrays-equal-by-reversing-sub-arrays/
namespace Make_Two_Arrays_Equal_by_Reversing_Sub_arrays
{
    public static class AppHelper
    {
        public static Boolean AreEqual(Int32[] target, Int32[] arr)
        {
            if (target.SequenceEqual(arr))
                return true;
            if (!target.OrderBy(g => g).SequenceEqual(arr.OrderBy(g => g)))
                return false;
            if (target.OrderBy(g => g).SequenceEqual(arr.OrderBy(g => g)))
                return true;
            return false;
        }
    }


    public class Solution
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            return AppHelper.AreEqual(target, arr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
