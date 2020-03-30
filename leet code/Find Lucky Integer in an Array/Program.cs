using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/find-lucky-integer-in-an-array/
/*
Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.

Return a lucky integer in the array. If there are multiple lucky integers return the largest of them. If there is no lucky integer return -1.

 

Example 1:

Input: arr = [2,2,3,4]
Output: 2
Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
Example 2:

Input: arr = [1,2,2,3,3,3]
Output: 3
Explanation: 1, 2 and 3 are all lucky numbers, return the largest of them.
Example 3:

Input: arr = [2,2,2,3,3]
Output: -1
Explanation: There are no lucky numbers in the array.
Example 4:

Input: arr = [5]
Output: -1
Example 5:

Input: arr = [7,7,7,7,7,7,7]
Output: 7 
*/

namespace Find_Lucky_Integer_in_an_Array
{
    public static class AppHelper
    {
        public static Int32 LuckyIntgr(Int32[] arr)
        {
            Int32 returnVal = -1;
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict[arr[i]] = 1;
                }
            }
            if (dict.All(a => a.Key == a.Value))
            {
                if (arr.All(g => g == arr.First()))
                {
                    returnVal = arr[0];
                }
                else
                {
                    returnVal = arr.Max();
                }
            }
            else if (dict.Any(a => a.Key == a.Value))
            {
                returnVal = dict.OrderByDescending(g => g.Key).Where(a => a.Key == a.Value).Select(a => a.Key).First();
            }
            return returnVal;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 5, 4, 7, 8, 4, 8, 8, 3, 7, 7, 6, 3, 7, 6, 5, 6, 8, 4, 5, 7, 4, 7, 7, 5, 2, 5, 6, 6, 8, 1, 6, 8, 8, 8, 9, 3, 2, 9 };
            int k = AppHelper.LuckyIntgr(arr);
            Console.ReadLine();
        }
    }
}
