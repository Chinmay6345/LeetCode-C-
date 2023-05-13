using System;
using System.Collections.Generic;

namespace Search_For_Range
{
    //https://www.algoexpert.io/questions/Search%20For%20Range
    public static class AppHelper
    {
        public static Int32 Search(Int32[] arr, Int32 target, bool goLeft)
        {
            Array.Sort(arr);
            Int32 n = arr.Length;
            Int32 low = 0;
            Int32 high = n - 1;
            Int32[] nums = { -1, -1 };
            while (low <= high)
            {
                Int32 mid = (low + high) / 2;
                if (target > arr[mid])
                {
                    low = mid + 1;
                }
                else if (target < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    if (goLeft)
                    {
                        if (mid == 0 || arr[mid - 1] != target)
                        {
                            nums[0] = mid;
                            return nums[0];
                        }
                        else
                        {
                            high = mid - 1;
                        }
                    }
                    else
                    {
                        if (mid == n - 1 || arr[mid + 1] != target)
                        {
                            nums[1] = mid;
                            return nums[1];
                        }
                        else
                        {
                            low = mid + 1;
                        }
                    }
                }
            }
            return -1;
        }
    }



    public class Program
    {
        public static void Main(String[] args)
        {
            int[] array = { 1, 2, 5, 2, 3 };
            Int32[] nums = new Int32[2];
            nums[0] = AppHelper.Search(array, 2, true);
            nums[1] = AppHelper.Search(array, 2, false);
            IList<int> lst = new List<int>();
            if (nums[0] != -1)
                lst.Add(nums[0]);
            if (nums[1] != -1)
            {
                lst.Add(nums[1]);
            }
            Console.ReadLine();
        }
    }
}

