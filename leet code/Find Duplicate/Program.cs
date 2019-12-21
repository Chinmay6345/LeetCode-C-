using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Duplicate
{
    //https://leetcode.com/problems/find-the-duplicate-number/submissions/
    public static class AppHelper
    {
        public static int SingleNum(int[] nums)
        {
            try
            {
                if (nums.Length == 1)
                {
                    return nums[0];
                }
                else
                {
                    var result = nums.GroupBy(element => element).Where(a => a.Count() > 1).FirstOrDefault();
                    return Convert.ToInt32(result.Key.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AppHelper.SingleNum(new int[] { 1, 3, 4, 2, 2  }));
            Console.ReadLine();
        }
    }
}
