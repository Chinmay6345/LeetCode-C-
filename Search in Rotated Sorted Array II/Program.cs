using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search_in_Rotated_Sorted_Array_II
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
    public static class AppHelper
    {
        public static Boolean Search(int[] nums, int target)
        {
            if (nums.Length == 0)
            {
                return false;
            }
            if (nums.Any(a=>a== target))
            {
                return true;
            }
            else
                return false;            
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 1 };
            bool p = AppHelper.Search(array, 1);
            Console.ReadLine();
        }
    }
}
