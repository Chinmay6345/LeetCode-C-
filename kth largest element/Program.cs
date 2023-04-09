using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kth_largest_element
{
    //https://leetcode.com/problems/kth-largest-element-in-an-array/
    public static class AppHelper
    {
        public static int FindKthLargest(int[] array, int k)
        {
            Array.Sort<int>(array, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));
            int element = array[k - 1];
            return element;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(new String[] { "," }, StringSplitOptions.RemoveEmptyEntries).Select(a => int.Parse(a)).ToArray();
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(AppHelper.FindKthLargest(array, n));
            Console.ReadLine();
        }
    }
}
