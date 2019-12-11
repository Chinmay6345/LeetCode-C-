using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    public static class AppHelper
    {
        public static List<Tuple<int, int>> GetPairBrute(int[] ints, int sum, List<Tuple<int, int>> lst)
        {
            for (int i = 0; i < ints.Length - 1; i++)
            {
                for (int j = i + 1; j < ints.Length; j++)
                {
                    Console.WriteLine("i=" + ints[i] + " j=" + ints[j]);
                    Console.WriteLine(j);
                    if (ints[i] + ints[j] == sum)
                    {
                        lst.Add(new Tuple<int, int>(i, j));
                    }
                }
            }
            return lst;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            int[] array = { 3, 2, 3 };
            var p = AppHelper.GetPairBrute(array, 6, new List<Tuple<int, int>>());
            List<int> newlist = new List<int>();
            for (int i = 0; i < p.Count; i++)
            {
                newlist.Add(p[i].Item1);
                newlist.Add(p[i].Item2);
            }
            int[] returnarray = newlist.ToArray();
            Console.ReadLine();
        }
    }
}
