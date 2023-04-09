using System;
using System.Collections.Generic;
using System.Linq;

namespace Third_Maximum
{
    public static class AppHelper
    {
        public static Int32 ThirdMaximum(Int32 [] nums,int k)
        {
            Int32 Length = nums.Length;
            if(Length <3)
            {
                return nums[0];
            }
            nums= nums.OrderByDescending(element => element).ToArray<Int32>();
            return nums[k - 1];
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 2, 2, 3, 1 };
           int p = AppHelper.ThirdMaximum(array, 3);
           Console.ReadLine();
        }
    }
}
