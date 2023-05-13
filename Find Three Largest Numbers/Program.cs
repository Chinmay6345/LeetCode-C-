using System;
using System.Linq;

namespace Find_Three_Largest_Numbers
{
    //https://www.algoexpert.io/questions/Find%20Three%20Largest%20Numbers

    public static class AppHelper
    {
        public static Int32[] ThreeLargest(Int32[] arr)
        {
            Int32[] nums = Enumerable.Repeat(Int32.MinValue, 3).ToArray<Int32>();
            for (Int32 i = 0; i < arr.Length; i++)
            {
                if (arr[i] > nums[2])
                {
                    Update(ref nums, 2, arr[i]);
                }
                else if (arr[i] > nums[1])
                {
                    Update(ref nums, 1, arr[i]);
                }
                else if (arr[i] > nums[0])
                {
                    Update(ref nums, 0, arr[i]);
                }
            }
            return nums;
        }

        public static void Update(ref int[] nums, int idx, int num)
        {
            for (Int32 j = 0; j <= idx; j++)
            {
                if (j == idx)
                    nums[j] = num;
                else
                    nums[j] = nums[j + 1];
            }
        }
    }


    //public abstract class Chin
    //{
    //    public void call()
    //    {

    //    }
    //    public abstract void Print();
    //    public abstract int see { get; }
    //    public Chin()
    //    {
    //        Console.WriteLine("print");
    //    }
    //}

    interface a
    {
        void one();
        void two();
    }

    interface b
    {
        void three();
        void four();
    }

    class Program 
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            //Int32 [] arr = { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 };
            //Int32 [] result = AppHelper.ThreeLargest(arr);
            Console.ReadLine();
        }
    }
}
