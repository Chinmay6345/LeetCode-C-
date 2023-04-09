using System;
using System.Linq;

//https://leetcode.com/problems/element-appearing-more-than-25-in-sorted-array/

namespace Element_Appearing_More_Than_25_perrcent_In_Sorted_Array
{
    public class Solution
    {
        public int FindSpecialInteger(int[] arr)
        {
            return arr.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution sol = new Solution();
            Int32 k = sol.FindSpecialInteger(new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 });
            Console.WriteLine(k);
            Console.ReadLine();
        }
    }
}
