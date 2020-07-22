using System;
using System.Linq;
//https://leetcode.com/problems/single-number/
namespace Single_Number
{
    public static class AppHelper
    {
        public static int BSingleNum(int[] nums)
        {
            try
            {
                Int32 i = 0, res = 0;
                for (; i < nums.Length; i++)
                {
                    res = res ^ nums[i];
                }
                return res;
            }
            catch (Exception)
            {
                throw;
            }
        }
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
                    var result = nums.GroupBy(element => element).Where(a => a.Count() == 1).FirstOrDefault();
                    return Convert.ToInt32(result.Key.ToString());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }

    public class Solution
    {
        public int SingleNumber(int[] nums)
        {
            return AppHelper.SingleNum(nums);
        }
    }
}
