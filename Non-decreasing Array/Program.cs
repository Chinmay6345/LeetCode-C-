using System;
using System.Linq;
//https://leetcode.com/problems/non-decreasing-array/
namespace Non_decreasing_Array
{
    public static class AppHelper
    {
        public static bool IsSorted(int[] a)
        {
            int j = a.Length - 1;
            if (j < 1) return true;
            int ai = a[0], i = 1;
            while (i <= j && ai <= (ai = a[i])) i++;
            return i > j;
        }

        public static Boolean CheckPossibility(int[] arr)
        {
            if (arr.All(g => g == arr.First()))
                return true;
            for (Int32 i = 0; i < arr.Length; i++)
            {
                if (i == arr.Length - 1)
                {
                    arr[i] = Int32.MaxValue;
                    if (IsSorted(arr))
                        return true;
                }
                Int32 k = arr[i];
                arr[i] = (i == 0 ? 0 : arr[i - 1]);
                if (IsSorted(arr))
                    return true;
                else
                {
                    if (i + 1 < arr.Length)
                    {
                        arr[i] = arr[i + 1];
                        if (IsSorted(arr))
                            return true;
                    }
                }
                arr[i] = k;
            }
            return false;
        }
    }

    public class Solution
    {
        public bool CheckPossibility(int[] nums)
        {
            return AppHelper.CheckPossibility(nums);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
