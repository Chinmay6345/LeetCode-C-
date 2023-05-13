using System;
using System.Collections.Generic;

namespace Fractional_Knapsack
{
    public class Item
    {
        public int weight;
        public int value;

        public Item(int w, int v)
        {
            weight = w;
            value = v;
        }
    }

    public class cprCompare : IComparer<Item>
    {
        public int Compare(Item x, Item y)
        {
            Item item1 = x;
            Item item2 = y;
            double cpr1 = (double)item1.value /
                          (double)item1.weight;
            double cpr2 = (double)item2.value /
                          (double)item2.weight;

            if (cpr1 < cpr2)
                return 1;

            return cpr1 > cpr2 ? -1 : 0;
        }
    }



    public static class AppHelper
    {
        public static double fracKnapSack(Item[] arr, int n, int w)
        {
            Array.Sort(arr, new cprCompare());
            double totalVal = 0f;
            int currW = 0;

            foreach (Item i in arr)
            {
                float remaining = w - currW;

                // If the whole item can be 
                // taken, take it 
                if (i.weight <= remaining)
                {
                    totalVal += (double)i.value;
                    currW += i.weight;
                }

                // dd fraction until we run out of space 
                else
                {
                    if (remaining == 0)
                        break;

                    double fraction = remaining / (double)i.weight;
                    totalVal += fraction * (double)i.value;
                    currW += (int)(fraction * (double)i.weight);
                }
            }
            return totalVal;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Item[] arr = {new Item(10, 60),
                      new Item(40, 40),
                      new Item(20, 100),
                      new Item(30, 120)};

            int n = 4, W = 50;
            Console.WriteLine("Maximum value we can obtain = " + AppHelper.fracKnapSack(arr, n, W));
            Console.ReadLine();
        }
    }
}
