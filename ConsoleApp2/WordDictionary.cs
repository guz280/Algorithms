using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    
 

	public class WordDictionary
	{
        // Design a data structure that supports adding new words and finding if a string matches any previously added string.
        // Implement the WordDictionary class:
        // WordDictionary() Initializes the object.
        // void addWord(word) Adds word to the data structure, it can be matched later.
        // bool search(word) Returns true if there is any string in the data structure that matches word or false otherwise.
        // word may contain dots '.' where dots can be matched with any letter.



        // 26 letters
        public class TrieNode
        {
            public TrieNode[] children;
            public bool isWord;
            public TrieNode()
            {
                children = new TrieNode[26];
                isWord = false;
            }
        }

        private TrieNode root;
        public WordDictionary()
        {
            root = new TrieNode();
        }

        public void AddWord(string word)
        {
            TrieNode cur = root;
			foreach (var c in word.ToCharArray())
			{
                int index = (int)(c - 'a');
                if(cur.children[index] == null)
				{
                    cur.children[index] = new TrieNode();
				}
                cur = cur.children[index];
			}
            cur.isWord = true;
            
        }

        public bool Search(string word)
        {
            return Find(word, root, 0);
        }

        private Boolean Find(string word, TrieNode cur, int index)
		{
            if(index == word.Length)
			{
                return cur.isWord;
			}

            char c = word.ToCharArray()[index];
            if(c == '.')
			{
				for (int i = 0; i < 26; i++)
				{
                    if(cur.children[i] != null && Find(word, cur.children[i], index+1))
                    { return true; }
				}
                return false;
			}
			else
			{
                return cur.children[c - 'a'] != null && Find(word, cur.children[c - 'a'], index + 1);
			}
		}
    }
}
