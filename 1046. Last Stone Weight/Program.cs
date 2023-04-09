using System;
using System.Collections.Generic;
using System.Linq;
/// <summary>
/// 
/// </summary>
namespace _1046.Last_Stone_Weight
{
    //https://leetcode.com/problems/last-stone-weight/description/
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 7, 4, 1, 8, 1 };
            int last = AppHelper.LastStoneWeight(arr);
            Console.ReadLine();
        }
    }

    public static class AppHelper
    {
        public static int LastStoneWeight(int[] stones)
        {
            MaxHeap maxheap = new MaxHeap(stones.ToList());
            while (maxheap.IsEmpty() == false)
            {
                if (maxheap.NoOfElements == 1)
                {
                    break;
                }
                int x = maxheap.Remove();
                int y = maxheap.Remove();
                if (x != y)
                {
                    maxheap.Insert(Math.Abs(y - x));
                }
            }
            return maxheap.IsEmpty() ? 0 : maxheap.Peek();
        }
    }

    public class MaxHeap
    {
        public List<int> heap = new List<int>();

        public MaxHeap(List<int> array)
        {
            heap = buildHeap(array);
        }

        public List<int> buildHeap(List<int> array)
        {
            int firstParentIdx = (array.Count() - 2) / 2;
            for (int currentIdx = firstParentIdx; currentIdx >= 0; currentIdx--)
            {
                siftDown(currentIdx, array.Count() - 1, array);
            }
            return array;
        }

        public void siftDown(int currentIdx, int endIdx, List<int> heap)
        {

            int left = (currentIdx * 2) + 1;
            while (left <= endIdx)
            {
                int k = (currentIdx * 2) + 2;
                int right = k <= endIdx ? k : -1;
                int idxToSwap = Int32.MinValue;

                if (right != -1 && heap[right] > heap[left])
                {
                    idxToSwap = right;
                }
                else
                {
                    idxToSwap = left;
                }
                if (heap[idxToSwap] > heap[currentIdx])
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

        public void siftUp(int currentIdx, List<int> heap)
        {
            int parentIdx = (currentIdx - 1) / 2;
            while (currentIdx > 0 && heap[currentIdx] > heap[parentIdx])
            {
                swap(currentIdx, parentIdx, heap);
                currentIdx = parentIdx;
                parentIdx = (currentIdx - 1) / 2;
            }
        }

        public int Peek()
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

        public int Remove()
        {
            swap(0, heap.Count() - 1, heap);
            int valToRemove = heap[heap.Count() - 1];
            heap.RemoveAt(heap.Count() - 1);
            siftDown(0, heap.Count() - 1, heap);
            return valToRemove;
        }

        public void Insert(int value)
        {
            heap.Add(value);
            siftUp(heap.Count() - 1, heap);
        }

        private void swap(int i, int j, List<int> heap)
        {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }
}
