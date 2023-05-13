using System;
using System.Collections.Generic;
using System.Linq;

namespace _2248._Intersection_of_Multiple_Arrays
{
    //https://leetcode.com/problems/intersection-of-multiple-arrays/
    public class Solution
    {
        public IList<int> Intersection(int[][] nums)
        {
            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            foreach (int[] arr in nums)
            {
                foreach (int i in arr)
                {
                    if (!map.ContainsKey(i))
                    {
                        // Console.WriteLine(i);
                        map.Add(i, 1);
                    }
                    else
                    {
                        map[i]++;
                    }
                }
            }
            List<int> lst = new List<int>();
            foreach (int val in map.Keys)
            {
                if (map[val] == nums.Length)
                {
                    lst.Add(val);
                }
            }
            return lst;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] nums = new int[][]
            {
                new int[] { 3,1,2,4,5 },
                new int[] { 1,2,3,4},
                new int[] { 3, 4, 5, 6 }
            };
            Console.ReadLine();
        }
    }
}
