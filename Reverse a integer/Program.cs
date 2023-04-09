using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_a_integer
{
    public static class AppHelper
    {   
        public static int Reverse(int num)
        {
            try
            {
                int reverse = 0;
                bool isnegative = false;
                int returnvalue;
                if (num < 0)
                {
                    isnegative = true;
                    num = Math.Abs(num);
                }
                while (num > 0)
                {
                    reverse = checked((reverse * 10) + num % 10);
                    num = num / 10;
                }
                if (reverse > int.MaxValue)
                {
                    return 0;
                }
                returnvalue = (isnegative == false) ? reverse : -Math.Abs(reverse);
                return returnvalue;
            }
            catch(Exception)
            {
                return 0;
            }
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int p= AppHelper.Reverse(1534236469);
            Console.ReadLine();
        }
    }
}
