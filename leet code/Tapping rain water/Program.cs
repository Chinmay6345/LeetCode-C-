using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tapping_rain_water
{
    public static class AppHelper
    {
        public static Int32 MaxWater(Int32[] height)
        {
            if (height.Length == 0)
            {
                return 0;
            }
            int ans = 0;
            int size = height.Length;
            Int32[] left_max = new Int32[size];
            Int32[] right_max = new Int32[size];
            left_max[0] = height[0];
            for (int i = 1; i < size; i++)
            {
                left_max[i] = Math.Max(height[i], left_max[i - 1]);
            }
            right_max[size - 1] = height[size - 1];
            for (int i = size - 2; i >= 0; i--)
            {
                right_max[i] = Math.Max(height[i], right_max[i + 1]);
            }
            for (int i = 1; i < size - 1; i++)
            {
                ans += Math.Min(left_max[i], right_max[i]) - height[i];
            }
            return ans;
        }
    }


    public class Solution
    {
        public int Trap(int[] height)
        {

            return AppHelper.MaxWater(height);
        }
    }
}
