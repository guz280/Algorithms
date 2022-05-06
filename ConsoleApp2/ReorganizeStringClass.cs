using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public static class ReorganizeStringClass
	{
        // Given a string s, rearrange the characters of s so that any two adjacent characters are not the same.
        // Return any possible rearrangement of s or return "" if not possible.
        public static string ReorganizeString(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Dictionary<char, int> dict2 = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                dict.TryGetValue(s[i], out int count);
                if (count > 0)//it exists
                {
                    count += 1;
                    dict[s[i]] = count;
                }
                else //does not exist add it to dictionary
                {
                    dict[s[i]] = 1;
                }
            }


            foreach (KeyValuePair<char, int> pait in dict.OrderByDescending(key => key.Value))
            {
                dict2.Add(pait.Key, pait.Value);
            }

            char[] newString = new char[s.Length];

            int startPos = 0;
            int initial = 0;
            foreach (char c in dict2.Keys)
            {
                startPos = initial;
                dict.TryGetValue(c, out int count);
                newString[initial] = c;
                startPos++;
                for (int i = 1; i < count; i++)
                {
                    if (startPos + 1 < s.Length)
                    {
                        newString[startPos + 1] = c;
                        startPos += 2;
                    }
                    else { return "not possible"; }
                }
                initial++;
            }

            string resultString = "";
            for (int i = 0; i < newString.Length; i++)
            {
                resultString = resultString + newString[i].ToString();

            }

            return resultString;

        }
    }
}
