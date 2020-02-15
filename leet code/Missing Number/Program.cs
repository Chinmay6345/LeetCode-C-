using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://leetcode.com/problems/missing-number/

namespace Missing_Number
{
    public static class AppHelper
    {
        public static Int32 Missing(int[] array)
        {
            int missing = 0;
            Array.Sort<int>(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == i)
                {
                    missing = missing + 1;
                }
            }
            return missing;
        }
    }


    public class Solution
    {
        public int MissingNumber(int[] nums)
        {
            return AppHelper.Missing(nums);
        }
    }
}
