using System;
using System.Collections.Generic;
using System.Linq;

//https://leetcode.com/problems/find-all-duplicates-in-an-array/
/*
Given an array of integers, 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.

Find all the elements that appear twice in this array.

Could you do it without extra space and in O(n) runtime?

Example:
Input:
[4,3,2,7,8,2,3,1]

Output:
[2,3] 
*/

namespace Find_All_Duplicates_in_an_Array
{
    public static class HelperMethods
    {
        public static List<Int32> lstDuplicates(Int32[] arr)
        {
            try
            {
                List<Int32> lst = new List<Int32>();
                if (arr.Length == 1)
                {
                    return lst;
                }
                Dictionary<Int32, Int32> Hmap = new Dictionary<Int32, Int32>();

                for (Int32 i = 0; i < arr.Length; i++)
                {
                    if (Hmap.ContainsKey(arr[i]))
                    {
                        Hmap[arr[i]]++;
                    }
                    else
                    {
                        Hmap[arr[i]] = 1;
                    }
                }
                return Hmap.Where(a => a.Value > 1).Select(g => g.Key).ToList<Int32>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    public class Solution
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            List<Int32> lst = new List<Int32>();
            try
            {
                lst = HelperMethods.lstDuplicates(nums);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
                lst = null;
            }
            return lst;
        }
    }
}

