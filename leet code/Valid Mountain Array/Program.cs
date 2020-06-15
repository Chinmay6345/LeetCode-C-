using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/valid-mountain-array/
/*
Example 1:

Input: [2,1]
Output: false
Example 2:

Input: [3,5,5]
Output: false
Example 3:

Input: [0,3,2,1]
Output: true
 

Note:

0 <= A.length <= 10000
0 <= A[i] <= 10000 
  
*/
namespace Valid_Mountain_Array
{
    public static class AppHelper
    {
        public static bool IsSortedAsc(Int32[] a, Int32 max)
        {
            if (a.Length == 0 || a.Contains(max))
            {
                return false;
            }
            Int32 j = a.Length - 1;
            if (j < 1)
            {
                return true;
            }
            Int32 ai = a[0], i = 1;
            while (i <= j && ai <= (ai = a[i])) i++;
            return i > j;
        }
        public static bool IsSortedDsc(Int32[] arr, Int32 max)
        {
            bool isValid = false;
            if (arr.Length == 0 || arr.Contains(max))
            {
                return false;
            }
            if (arr.Length == 1)
            {
                isValid = true;
                return isValid;
            }
            for (Int32 i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    isValid = true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        public static Boolean ValidMountainArray(Int32[] arr)
        {
            Int32 max = arr.Max();
            Int32 maxIndex = Array.IndexOf<Int32>(arr, max);
            List<Int32> left_lst = new List<Int32>();
            List<Int32> right_lst = new List<Int32>();
            for (Int32 i = 0; i < maxIndex; i++)
            {
                left_lst.Add(arr[i]);
            }
            for (Int32 j = maxIndex + 1; j < arr.Length; j++)
            {
                right_lst.Add(arr[j]);
            }
            bool asc = IsSortedAsc(left_lst.ToArray(), max);
            bool dsc = IsSortedDsc(right_lst.ToArray(), max);
            if (asc && dsc)
            {
                return true;
            }
            return false;
        }
    }

    public class Solution
    {
        public bool ValidMountainArray(int[] A)
        {
            if (A.Length == 0)
            {
                return false;
            }
            return AppHelper.ValidMountainArray(A);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
