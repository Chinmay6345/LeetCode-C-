using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_colors
{
    public class Solution
    {
        public void SortColors(int[] nums)
        {
            Array.Sort<int>(nums, new Comparison<int>(
                       (i1, i2) => i1.CompareTo(i2)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            s.SortColors(new int[] {2,0,2,1,1,0 });
        }
    }
}
