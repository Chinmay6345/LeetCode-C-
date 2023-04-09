using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace _1405._Longest_Happy_String
{
    //https://leetcode.com/problems/longest-happy-string/description/
    class Program
    {
        static void Main(string[] args)
        {
            string output = AppHelper.LongestDiverseString(a:1, b:1, c:7);
            Console.ReadLine();
        }
    }

    public static class AppHelper
    {
        public static string LongestDiverseString(int a, int b, int c)
        {
            List<Pair> lst = new List<Pair>();
            if(a > 0)
            {
                lst.Add(new Pair(a, 'a'));
            }
            if (b > 0)
            {
                lst.Add(new Pair(b, 'b'));
            }
            if (c > 0)
            {
                lst.Add(new Pair(c, 'c'));
            }
            MaxHeap maxHeap = new MaxHeap(lst);
            StringBuilder res = new StringBuilder();
            bool  valid=false;
            while (maxHeap.IsEmpty()==false)
            {
                Pair p1 = maxHeap.Remove();
                             
                if (res.Length > 1 && valid && res[res.Length - 1] - 'a'== res[res.Length - 2] - 'a' && p1.Character - 'a'== res[res.Length - 2] - 'a')
                {
                    if(maxHeap.IsEmpty())
                    {
                        break;
                    }
                    Pair p2 = maxHeap.Remove();
                    res.Append(p2.Character.ToString());
                    p2.count = p2.count - 1;
                    if (p2.count != 0)
                    {
                        maxHeap.Insert(p2);
                    }
                }               
                else
                {
                    res.Append(p1.Character.ToString());
                    p1.count = p1.count - 1;
                }
                if(p1.count >0)
                {
                    maxHeap.Insert(p1);
                }
            }
            return Convert.ToString(res);
        }
    }

    public class Pair
    {
        public int count;
        public char Character;

        public Pair(int cnt,char char1)
        {
            count = cnt;
            Character = char1;
        }
    }


    public class MaxHeap
    {
        public List<Pair> heap = new List<Pair>();

        public MaxHeap(List<Pair> array)
        {
            heap = buildHeap(array);
        }

        public List<Pair> buildHeap(List<Pair> array)
        {
            int firstParentIdx = (array.Count() - 2) / 2;
            for (int currentIdx = firstParentIdx; currentIdx >= 0; currentIdx--)
            {
                siftDown(currentIdx, array.Count() - 1, array);
            }
            return array;
        }

        public void siftDown(int currentIdx, int endIdx, List<Pair> heap)
        {

            int left = (currentIdx * 2) + 1;
            while (left <= endIdx)
            {
                int k = (currentIdx * 2) + 2;
                int right = k <= endIdx ? k : -1;
                int idxToSwap = Int32.MinValue;

                if (right != -1 && heap[right].count > heap[left].count)
                {
                    idxToSwap = right;
                }
                else
                {
                    idxToSwap = left;
                }
                if (heap[idxToSwap].count > heap[currentIdx].count)
                {
                    swap(currentIdx, idxToSwap, heap);
                    currentIdx = idxToSwap;
                    left = (currentIdx * 2) + 1;
                }
                else
                {
                    return;
                }
            }
        }

        public void siftUp(int currentIdx, List<Pair> heap)
        {
            int parentIdx = (currentIdx - 1) / 2;
            while (currentIdx > 0 && heap[currentIdx].count > heap[parentIdx].count)
            {
                swap(currentIdx, parentIdx, heap);
                currentIdx = parentIdx;
                parentIdx = (currentIdx - 1) / 2;
            }
        }

        public Pair Peek()
        {
            return heap[0];
        }

        public bool IsEmpty()
        {
            return heap.Count == 0;
        }

        public int NoOfElements
        {
            get
            {
                return heap.Count;
            }
        }

        public Pair Remove()
        {
            swap(0, heap.Count() - 1, heap);
            Pair valToRemove = heap[heap.Count() - 1];
            heap.RemoveAt(heap.Count() - 1);
            siftDown(0, heap.Count() - 1, heap);
            return valToRemove;
        }

        public void Insert(Pair value)
        {
            heap.Add(value);
            siftUp(heap.Count() - 1, heap);
        }

        private void swap(int i, int j, List<Pair> heap)
        {
            Pair temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
