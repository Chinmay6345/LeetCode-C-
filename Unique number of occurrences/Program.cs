using System;
using System.Collections.Generic;
using System.Linq;
namespace Unique_number_of_occurrences
{
    public static class Solution
    {
        public static Boolean UniqueOccurrences(int[] arr)
        {
            Dictionary<Int32, Int32> dictionary = new Dictionary<Int32, Int32>();
            foreach (Int32 element in arr)
            {
                if (!dictionary.ContainsKey(element))
                {
                    dictionary[element] = 1;
                }
                else
                {
                    dictionary[element]++;
                }
            }
            if (dictionary.GroupBy(x => x.Value).Where(y => y.Count() > 1).Count() == 0)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution.UniqueOccurrences(new Int32 [] { 1,2,2,1,1,3 }));
            Console.ReadLine();
        }
    }
}
