using System;
using System.Collections.Generic;

namespace G_CircularTour
{
    public static class AppHelper
    {
        public static int tour(int [] petrol, int [] distance)
        {
            int deficit = 0, start = 0, cal = 0;
            for (int i = 0; i < petrol.Length; i++)
            {
                Console.WriteLine(petrol[i] - distance[i]);
                cal += petrol[i] - distance[i];
                if (cal < 0)
                {
                    start = i + 1;
                    deficit += cal;
                    cal = 0;
                }

            }

            return (cal + deficit) > 0 ? start : -1;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] petrol = { 4, 6, 7, 4, };
            int[] distance = { 6, 5, 3, 5 };
            Console.WriteLine(AppHelper.tour(petrol, distance));
            Console.ReadLine();
        }
    }
}
