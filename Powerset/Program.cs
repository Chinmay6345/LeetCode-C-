using System;
using System.Linq;
using System.Collections.Generic;

namespace Powerset
{
    public static class AppHelper
    {
        //Time Complexity=Space Complexit=O(n*2^n)
        public static List<List<Int32>> PowerSet(Int32[] array)
        {
            List<List<Int32>> subsets = new List<List<int>>();
            subsets.Add(new List<Int32>());
            foreach (Int32 ele in array)
            {
                Int32 count = subsets.Count();
                for (Int32 i = 0; i < count; i++)
                {
                    List<Int32> set = new List<int>(subsets[i]);
                    set.Add(ele);
                    subsets.Add(set);
                }
            }
            var distinctlist = subsets.Select(o =>
            {
                var t = o.OrderBy(x => x).Select(i => i.ToString());
                return new { Key = string.Join("", t), List = o };
            }).GroupBy(o => o.Key).Select(o => o.FirstOrDefault()).Select(o => o.List).ToList();
            return subsets;
        }

        public static IList<IList<Int32>> Subsets(Int32[] nums)
        {
            return RSets(nums, nums.Length - 1);
        }

        public static IList<IList<Int32>> RSets(Int32[] nums, Int32 i)
        {
            if (i < 0)
            {
                IList<IList<Int32>> emptySubsets = new List<IList<Int32>>();
                emptySubsets.Add(new List<Int32>());
                return emptySubsets;
            }
            int ele = nums[i];
            IList<IList<Int32>> Subsets = RSets(nums, i - 1);
            Int32 count = Subsets.Count();
            for (Int32 j = 0; j < count; j++)
            {
                List<Int32> set = new List<int>(Subsets[i]);
                set.Add(ele);
                Subsets.Add(set);
            }
            return Subsets;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 2, 2, 2 };
            var result = AppHelper.PowerSet(arr);
            Console.ReadLine();
        }
    }
}
