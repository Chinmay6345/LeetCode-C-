using System;

namespace Trie_CRUD
{
    
    public class Trie
    {

        public class TrieNode
        {
            public TrieNode[] child;
            public bool isEnd;

            public TrieNode()
            {
                isEnd = false;
                child = new TrieNode[26];
                for (int i = 0; i < child.Length; i++)
                {
                    child[i] = null;
                }
            }
        }

        public TrieNode root;
        public void Insert(String key)
        {
            var pCrawl = new TrieNode();
            int len = key.Length;
            int level;
            int index;
            for (level = 0; level < len; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.child[index] == null)
                    pCrawl.child[index] = new TrieNode();

                pCrawl = pCrawl.child[index];
            }
            pCrawl.isEnd = true;
            root = pCrawl;
        }

        public bool Search(String key)
        {
            var pCrawl = root;
            int len = key.Length;
            int level;
            int index;
            for (level = 0; level < len; level++)
            {
                index = key[level] - 'a';
                if (pCrawl.child[index] == null)
                    pCrawl.child[index] = new TrieNode();

                pCrawl = pCrawl.child[index];
            }
            return (pCrawl != null && pCrawl.isEnd);
        }
    }
        
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Trie trie= new Trie();
            trie.Insert("bad");
            bool s = trie.Search("bad");
            Console.ReadLine();
        }
    }
}
