using System.Linq;
using System;
//https://leetcode.com/problems/n-repeated-element-in-size-2n-array/

namespace N_Repeated_Element_in_Size_2N_Array
{
    public static class AppHelper
    {
        public static int RepeatedNTimes(int[] A)
        {
            return int.Parse(A.GroupBy(a => a).Where(a => a.Count<int>() > 1).Select(k => new { Key = k.Key }).FirstOrDefault().Key.ToString());
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int k = AppHelper.RepeatedNTimes(new int[] { 1, 2, 3, 3 });
        }
    }
}
