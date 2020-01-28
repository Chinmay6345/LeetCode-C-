using System;
using System.Linq;
using System.Numerics;

//https://leetcode.com/problems/plus-one/
namespace Plus_One
{
    public static class Solution
    {
        public static int[] PlusOne(int[] digits)
        {
            String Strdigits = String.Join("", digits);
            BigInteger PlusOne = BigInteger.Parse(Strdigits) + 1;
            String StrArray = Convert.ToString(PlusOne);
            Int64[] array = new Int64[StrArray.Length];
            Int32 count = 0;
            foreach (Char c in StrArray.ToCharArray())
            {
                array[count] = Convert.ToInt32(Convert.ToString(c));
                count++;
            }
            return array.Select(a => (Int32)a).ToArray<Int32>();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = Solution.PlusOne(new int[] { 1, 2, 3 });
            Console.ReadLine();
        }
    }
}
