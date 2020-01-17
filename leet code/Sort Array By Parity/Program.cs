using System;
using System.Linq;

//https://leetcode.com/problems/sort-array-by-parity/
namespace Sort_Array_By_Parity
{
    public static class AppHelper
    {
        public static Int32[] Sorted(Int32[] array)
        {
            return array.OrderBy(a=>a %2 ==0 ? -a : a).ToArray();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] array = AppHelper.Sorted(new int[] { 4, 1, 3, 2 });
            Console.Write(String.Join(" ", array.Select(a => a)));
        }
    }
}
