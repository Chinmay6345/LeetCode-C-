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
        public static Int32 UsingHSet(Int32 [] arr)
        {
            ISet<Int32> HSet = new HashSet<Int32>();
            for(Int32 i=0;i<arr.Length;i++)
            {
                HSet.Add(arr[i]);
            }
            Int32 totalNoOfElements = arr.Length + 1;
            for(Int32 i=0;i<totalNoOfElements;i++)
            {
                if(!HSet.Contains(i))
                {
                    return i;
                }
            }
            return -1;
        }

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
