using System;
using System.Linq;
using System.Collections.Generic;

namespace _146._LRU_Cache
{
    //https://leetcode.com/problems/lru-cache/
    public class Node
    {
        public int key;
        public int val;
        public Node next;
        public Node prev;
        public Node(int k, int v)
        {
            key = k;
            val = v;
        }
    }


    public class LRUCache
    {
        public Dictionary<int, Node> map = null;
        public Node head;
        public Node tail;
        public int count = 0;
        public int size = 0;
        public LRUCache(int capacity)
        {
            size = capacity;
            count = 0;
            map = new Dictionary<int, Node>();
            head = new Node(0, 0);
            tail = new Node(0, 0);
            head.next = tail;
            head.prev = null;
            tail.next = null;
            tail.prev = head;
        }

        private void addToHead(Node node)
        {
            node.next = head.next;
            node.next.prev = node;
            head.next = node;
            node.prev = head;
        }

        private void deleteNode(Node node)
        {
            node.next.prev = node.prev;
            node.prev.next = node.next;
        }

        public int Get(int key)
        {
            if (map.ContainsKey(key))
            {
                Node node = map[key];
                int returnVal = node.val;
                deleteNode(node);
                addToHead(node);
                return returnVal;
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if (map.ContainsKey(key))
            {
                Node node = map[key];
                node.val = value;
                deleteNode(node);
                addToHead(node);
            }
            else
            {
                Node node = new Node(key, value);
                map.Add(key, node);
                if (count < size)
                {
                    count++;
                    addToHead(node);
                }
                else
                {
                    map.Remove(tail.prev.key);
                    deleteNode(tail.prev);
                    addToHead(node);
                }
            }
        }
    }

    /**
     * Your LRUCache object will be instantiated and called as such:
     * LRUCache obj = new LRUCache(capacity);
     * int param_1 = obj.Get(key);
     * obj.Put(key,value);
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "abacbc";
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (map.ContainsKey(c))
                    map[c]++;
                else
                    map[c] = 1;
            }
            int first = map.ElementAt(0).Value;
            foreach(int val in map.Values)
            {
                if (val != first)
                    break;
                first = val;    
            }
    
            Console.WriteLine("Hello World!");
        }
    }
}
