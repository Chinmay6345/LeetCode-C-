using System;
using System.Linq;
namespace Minimum_Waiting_Time
{

    public static class AppHelper
    {
        public static Int32 MinWaitingTime(Int32 [] arr,Int32 arr_len)
        {
            arr = arr.OrderBy(g => g).ToArray();
            Int32 res = 0;
            for (Int32 i=1;i<arr_len;i++)
            {
                if(i==1)
                {
                    res = 1;
                    continue;
                }
                else
                {
                    for(int j=i-1;j>=0;j--)
                    {
                        res += arr[j];
                    }
                }
            }
            return res;

        }

        public static Int32 MinWaitingTime2(Int32[] arr, Int32 arr_len)
        {
            arr = arr.OrderBy(g => g).ToArray();
            Int32 res = 0;
            for (Int32 i = 0; i < arr_len; i++)
            {
                int current_element = arr[i];
                int no_of_elements_left = arr_len - (i + 1);
                res += no_of_elements_left * arr[i];
            }
            return res;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Int32[] arr = { 3, 2, 1, 2, 6 };
            Console.Write(AppHelper.MinWaitingTime2(arr, arr.Length));
            Console.ReadLine();
        }
    }
}
