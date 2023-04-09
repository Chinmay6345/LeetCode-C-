using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/monotonic-array/
/*
An array is monotonic if it is either monotone increasing or monotone decreasing.

An array A is monotone increasing if for all i <= j, A[i] <= A[j].  An array A is monotone decreasing if for all i <= j, A[i] >= A[j].

Return true if and only if the given array A is monotonic.

Example 1:

Input: [1,2,2,3] 
*/
namespace Monotonic_array
{
    public static class AppHelper
    {
        public static bool IsSorted<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            var y = list.First();
            return list.Skip(1).All(x =>
            {
                bool b = y.CompareTo(x) <= 0;
                y = x;
                return b;
            });
        }
        public static bool IsSortedD<T>(IEnumerable<T> list) where T : IComparable<T>
        {
            var y = list.First();
            return list.Skip(1).All(x =>
            {
                bool b = y.CompareTo(x) >= 0;
                y = x;
                return b;
            });
        }

    }
    public class Solution
    {
        public bool IsMonotonic(int[] A)
        {
            if (AppHelper.IsSorted(A))
            {
                return true;
            }
            else if (AppHelper.IsSortedD(A))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
