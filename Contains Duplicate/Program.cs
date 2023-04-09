using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains_Duplicate
{
    //https://leetcode.com/problems/contains-duplicate/

    /*
     Given an array of integers, find if the array contains any duplicates.

      Your function should return true if any value appears at least twice in the array, and it should return false if every element is distinct.

      Example 1:

      Input: [1,2,3,1]
      Output: true
      Example 2:

      Input: [1,2,3,4]
      Output: false
      Example 3:

      Input: [1,1,1,3,3,4,3,2,4,2]
      Output: true
    */

    public static class AppHelper
    {
        public static Boolean ContainsDuplicate(int[] arr)
        {
            Dictionary<Int32, Int32> map = new Dictionary<Int32, Int32>();
            for (Int32 i = 0; i < arr.Length; i++)
            {
                if (map.ContainsKey(arr[i]))
                    map[arr[i]]++;
                else
                    map[arr[i]] = 1;
            }
            return map.Any(g => g.Value > 1);
        }
        public static Boolean ContainsDuplicate_M2(Int32[] arr)
        {
            Array.Sort<Int32>(arr);
            for (Int32 i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                    return true;
            }
            return false;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool containsDup = AppHelper.ContainsDuplicate_M2(new Int32[] { 1, 2, 3, 1 });
            Console.ReadLine();
        }
    }
}
