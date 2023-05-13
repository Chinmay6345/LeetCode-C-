using System;

namespace No_of_distinct_substrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class TrieNode
    {
        public TrieNode[] children;
        public bool isEnd;

        public TrieNode()
        {
            this.children = new TrieNode[26];
            this.isEnd = false;
        }
        static TrieNode root = new TrieNode();
        static void insert(String str)
        {
            TrieNode cur = root;
            foreach (char ch in str)
            {
                int idx = ch - 'a';

                if (cur.children[idx] == null)
                    cur.children[idx] = new TrieNode();

                cur = cur.children[idx];
            }
            cur.isEnd = true;
        }
        public static int distinctSubstringCount(String str)
        {
            // will hold the count of unique substrings
            int cnt = 0;
            for (int i = 0; i <= str.Length; i++)
            {
                // start from root of trie each time as new
                // starting point
                TrieNode temp = root;
                for (int j = i; j < str.Length; j++)
                {
                    char ch = str[j];
                    // when char not present add it to the trie
                    if (temp.children[ch - 'a'] == null)
                    {
                        temp.children[ch - 'a']
                            = new TrieNode();
                        temp.isEnd = true;
                        cnt++;
                    }
                    // move on to the next char
                    temp = temp.children[ch - 'a'];
                }
            }
            return cnt;
        }
    }
}
