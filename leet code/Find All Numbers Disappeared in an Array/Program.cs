using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/

/*Given an array of integers where 1 ≤ a[i] ≤ n (n = size of array), some elements appear twice and others appear once.

Find all the elements of [1, n] inclusive that do not appear in this array.

Could you do it without extra space and in O(n) runtime? You may assume the returned list does not count as extra space.

Example:

Input:
[4,3,2,7,8,2,3,1]

Output:
[5,6]*/
namespace Find_All_Numbers_Disappeared_in_an_Array
{
    public static class HelperMethods
    {
        public static List<Int32> MissingNumbers(Int32[] arr)
        {
            try
            {
                HashSet<Int32> set = new HashSet<Int32>();
                for (Int32 i = 1; i <= arr.Length; i++)
                {
                    set.Add(i);
                }
                foreach (Int32 num in arr)
                {
                    set.Remove(num);
                }
                return new List<Int32>(set);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
    public class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            if (nums.Length == 0)
            {
                return new List<Int32>();
            }
            return HelperMethods.MissingNumbers(nums);
        }
    }
}
