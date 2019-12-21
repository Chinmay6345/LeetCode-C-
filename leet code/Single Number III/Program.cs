using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Number_III
{
    //https://leetcode.com/problems/single-number-iii/
    public static class AppHelper
    {
        public static int[] SingleNum(int[] nums)
        {
            try
            {
                if (nums.Length == 1)
                {
                    return nums;
                }
                else
                {
                    var result = nums.GroupBy(element => element).Where(a => a.Count() == 1);
                    int[] resultarray = result.SelectMany(a => a).ToArray();
                    return resultarray;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] nums = AppHelper.SingleNum(new int[] { 1, 2, 1, 3, 2, 5 });
            foreach(int i in nums)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
