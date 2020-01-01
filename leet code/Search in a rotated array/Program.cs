using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_in_a_rotated_array
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array/
    public static class AppHelper
    {
        public static int Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return -1;
            }
            if (nums.Contains<Int32>(target))
            {
                int index = Array.IndexOf<Int32>(nums, target);
                return index;
            }
            else
                return -1;            
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1 };
            int p = AppHelper.Search(array, 1);
            Console.ReadLine();
        }
    }
}
