using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/check-if-n-and-its-double-exist/

/*
Given an array arr of integers, check if there exists two integers N and M such that N is the double of M ( i.e. N = 2 * M).

More formally check if there exists two indices i and j such that :

i != j
0 <= i, j < arr.length
arr[i] == 2 * arr[j]
 

Example 1:

Input: arr = [10,2,5,3]
Output: true
Explanation: N = 10 is the double of M = 5,that is, 10 = 2 * 5.
Example 2:

Input: arr = [7,1,14,11]
Output: true
Explanation: N = 14 is the double of M = 7,that is, 14 = 2 * 7.
Example 3:

Input: arr = [3,1,7,11]
Output: false
Explanation: In this case does not exist N and M, such that N = 2 * M.
 

Constraints:

2 <= arr.length <= 500 
*/

namespace Check_If_N_and_Its_Double_Exist
{
    public static class AppHelper
    {
        public static bool Exists(Int32[] arr)
        {
            try
            {
                if (arr.All(g => g == arr.First()))
                {
                    return true;
                }
                List<Int32> lst = arr.ToList();
                lst.RemoveAll(g => g == 0 || g == 1 || g == -1);
                Boolean isFound = false;
                for (Int32 i = 0; i < lst.Count(); i++)
                {
                    Int32 current = lst[i];
                    Int32 divisor = current / 2;
                    if (divisor * 2 == current)
                    {
                        if (lst.Contains(current) && lst.Contains(divisor))
                        {
                            isFound = true;
                            break;
                        }
                    }
                }
                return isFound;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Boolean check = AppHelper.Exists(new Int32[] { 10, 2, 5, 3 });
        }
    }
}
