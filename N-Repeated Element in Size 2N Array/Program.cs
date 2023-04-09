using System.Linq;
using System;
//https://leetcode.com/problems/n-repeated-element-in-size-2n-array/
/*
 In a array A of size 2N, there are N+1 unique elements, and exactly one of these elements is repeated N times.

Return the element repeated N times.

 

Example 1:

Input: [1,2,3,3]
Output: 3
Example 2:

Input: [2,1,2,5,3,2]
Output: 2
Example 3:

Input: [5,1,5,2,5,3,5,4]
Output: 5
 */
namespace N_Repeated_Element_in_Size_2N_Array
{
    public static class AppHelper
    {
        public static int RepeatedNTimes(int[] A)
        {
            return int.Parse(A.GroupBy(a => a).Where(a => a.Count<int>() > 1).Select(k => new { Key = k.Key }).FirstOrDefault().Key.ToString());
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int k = AppHelper.RepeatedNTimes(new int[] { 1, 2, 3, 3 });
        }
    }
}
