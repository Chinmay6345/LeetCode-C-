using System;

namespace QuickSelect
{
    public static class AppHelper
    {
        public static Int32 QuickSelect(Int32[] arr, int k)
        {
            int position = k - 1;
            return QuickSelect(arr, 0, arr.Length - 1, position);

        }

        public static Int32 QuickSelect(Int32[] arr, Int32 startIdx, Int32 endIdx, Int32 position)
        {
            while (true)
            {
                if (startIdx > endIdx)
                {
                    throw new Exception("Invalid scenario");
                }
                int left = startIdx + 1;
                int right = endIdx;
                int pivot = startIdx;
                while (left <= right)
                {
                    if (arr[left] > arr[pivot] && arr[right] < arr[pivot])
                    {
                        swap(ref arr, left, right);
                    }
                    if (arr[left] <= arr[pivot])
                    {
                        left++;
                    }
                    if (arr[right] >= arr[pivot])
                    {
                        right--;
                    }
                }
                swap(ref arr, pivot, right);
                if (right == position)
                {
                    return arr[right];
                }
                else if (right > position)
                    endIdx = right - 1;
                else
                    startIdx = right + 1;
            }
        }

        public static void swap(ref int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 2, 1, 5, 6, 4 };
            int o = AppHelper.QuickSelect(arr, 2);
            Console.ReadLine();
        }
    }
}
