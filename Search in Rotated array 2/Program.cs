using System;

namespace Search_in_Rotated_array_2
{
    //https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
    public static class AppHelper
    {
        public static Int32 ShiftedBinarySearch(Int32 [] arr, Int32 target)
        {
            Int32 low = 0;
            Int32 high = arr.Length - 1;

            while (low <= high)
            {
                Int32 mid = (low + high) / 2;
                Int32 left = arr[low];
                Int32 right = arr[high];
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (left <= arr[mid])  //=> array is sorted
                {
                    if (target < arr[mid] && target >= left)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else
                {
                    if (target > arr[mid] && target <= right)
                        low = mid + 1;
                    else
                        high = mid - 1;
                }
            }
            return -1;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr= { 2, 5, 6, 0, 0, 1, 2 };
            int target =0;
            int k = AppHelper.ShiftedBinarySearch(arr, target);
            Console.ReadLine();
        }
    }
}
