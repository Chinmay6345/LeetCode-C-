using System;

namespace _2089__Find_Target_Indices_After_Sorting_Array
{
    //https://leetcode.com/problems/find-target-indices-after-sorting-array/


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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
