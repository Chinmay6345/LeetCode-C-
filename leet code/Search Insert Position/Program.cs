using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_Insert_Position
{
    //https://leetcode.com/problems/search-insert-position/
    public static class AppHelper
    {
        public static Int32 Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.Contains<Int32>(target))
            {
                return Array.IndexOf<Int32>(nums,target);
            }
            else
            {
                List<Int32> lst = new List<Int32>(nums);
                lst.Add(target);
                lst = lst.OrderBy(a => a).ToList<Int32>();
                return lst.IndexOf(target);
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1,3,5,6 };
            int p = AppHelper.Search(array, 0);
            Console.ReadLine();
        }
    }
}
