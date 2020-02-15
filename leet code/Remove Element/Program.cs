using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remove_Element
{
    public static class AppHelper
    {
        public static Int32 RemoveAllInstances(Int32[] nums, Int32 val)
        {
            if (nums.Length == 0)
            {
                return 0;
            }
            if (nums.All(g => g == nums.First()))
            {
                nums = nums.Where(matched => matched != val).ToArray<Int32>();
                return nums.Length;
            }
            Int32[] newarray = nums.Where(matched => matched != val).ToArray<Int32>();
            for (Int32 j = 0; j < newarray.Length; j++)
            {
                nums[j] = newarray[j];
            }
            return newarray.Length;
        }
    }

    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            return AppHelper.RemoveAllInstances(nums, val);
        }
    }
}
