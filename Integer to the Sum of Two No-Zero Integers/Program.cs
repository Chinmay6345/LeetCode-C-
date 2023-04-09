using System;

namespace Integer_to_the_Sum_of_Two_No_Zero_Integers
{
    public static class Solution
    {
        public static int[] GetNoZeroIntegers(int n)
        {
            Int32[] array = new Int32[2];
            int k = n;
            for (int i = 1; i < n; i++)
            {
                k = k - 1;
                if ((!i.ToString().Contains("0") && !k.ToString().Contains("0")))
                {
                    if (i + k == n)
                    {
                        array[0] = i;
                        array[1] = k;
                        break;
                    }
                }
            }
            return array;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Int32[] array = Solution.GetNoZeroIntegers(4);
        }
    }
}
