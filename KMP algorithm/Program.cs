using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMP_algorithm
{

    public static  class AppHelper
    {
        public static int[] kmpPreprocess(String pattern)
        {
            int i = 1, j = 0;
            int[] res = new int[pattern.Length];
            while (i < pattern.Length)
            {
                Console.Write(pattern[j]);
                if (pattern[i] == pattern[j])
                {
                    res[i] = j + 1;
                    i++; j++;
                }
                else if (j > 0)
                {
                    j = res[j - 1];
                }
                else
                {
                    res[i] = 0;
                    i++;
                }
            }
            return res;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double r = char.GetNumericValue('a');
            String s = "abacabad";
            var p = AppHelper.kmpPreprocess(s);
            Console.ReadLine();
        }
    }
}
