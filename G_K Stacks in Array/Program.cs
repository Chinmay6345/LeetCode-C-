using System;

namespace G_K_Stacks_in_Array
{
    internal class kStacks
    {
        int [] arr;
        int [] top;
        int [] next;
        int cap, k;
        int freeTop;

        public kStacks(int k1, int n)
        {
            k = k1; cap = n;
            arr = new int[cap];
            top = new int[k];
            next = new int[cap];

            for (int i = 0; i < k; i++)
                top[i] = -1;

            freeTop = 0;
            for (int i = 0; i < cap - 1; i++)
                next[i] = i + 1;
            next[cap - 1] = -1;
        }

        bool isFull() { return (freeTop == -1); }

        bool isEmpty(int sn) { return (top[sn] == -1); }

        public void push(int x, int sn)
        {
            if (isFull())
            {
                Console.WriteLine("\nStack Overflow\n");
                return;
            }

            int i = freeTop;
            freeTop = next[i];
            next[i] = top[sn];
            top[sn] = i;
            arr[i] = x;
        }

        public int pop(int sn)
        {
            if (isEmpty(sn))
            {
                Console.WriteLine("\nStack Underflow\n");
                return -999;
            }

            int i = top[sn];
            top[sn] = next[i];
            next[i] = freeTop;
            freeTop = i;
            return arr[i];
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int k = 3, n = 6;
            kStacks ks = new kStacks(k, n);
            ks.push(100, 0);
            ks.pop(0);
            Console.ReadLine();
        }
    }
}
