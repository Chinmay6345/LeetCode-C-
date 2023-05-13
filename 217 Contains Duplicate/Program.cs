using System;
using System.Collections.Generic;
using System.Linq;

namespace _217_Contains_Duplicate
{
    //https://leetcode.com/problems/contains-duplicate/
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<Int32> set = new HashSet<Int32>(nums);
            return !(set.Count() == nums.Length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
