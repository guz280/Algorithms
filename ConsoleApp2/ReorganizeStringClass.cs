using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public static class ReorganizeStringClass
	{
        // https://leetcode.com/problems/reorganize-string/
        // Given a string s, rearrange the characters of s so that any two adjacent characters are not the same.
        // Return any possible rearrangement of s or return "" if not possible.
        public static string ReorganizeString(string s)
        {
            Dictionary<char, int> dict = new Dictionary<char, int>();
            Dictionary<char, int> sortedDict = new Dictionary<char, int>();

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
                sortedDict.Add(pait.Key, pait.Value);
            }

            char[] newString = new char[s.Length];

            int startPos = 0;
            int initial = 0;


            foreach(KeyValuePair<char, int> kvp in sortedDict)
			{
                newString[startPos] = kvp.Key;


                for (int i = 1; i < kvp.Value; i++)
                {

                    startPos = startPos + 2;
                    if (startPos < s.Length)
                    {
                        newString[startPos] = kvp.Key;
                    }
                    else
                    {
                        return "Not Possible dude";
                    }
                }
                startPos = initial + 1;
            }

            //foreach (char c in dict2.Keys)
            //{
            //    startPos = initial;
            //    dict.TryGetValue(c, out int count);
            //    newString[initial] = c;
            //    startPos++;
            //    for (int i = 1; i < count; i++)
            //    {
            //        if (startPos + 1 < s.Length)
            //        {
            //            newString[startPos + 1] = c;
            //            startPos += 2;
            //        }
            //        else { return "not possible"; }
            //    }
            //    initial++;
            //}

            string resultString = "";
            for (int i = 0; i < newString.Length; i++)
            {
                resultString = resultString + newString[i].ToString();

            }

            return resultString;

        }









        public static string ReorganizeStringV2_Better(string s)
		{
            Dictionary<char, int> dict= new Dictionary<char, int>();

            for(int i=0; i < s.Length; i++)
			{
                dict.TryGetValue(s[i], out int count);
                if(count > 0) // it exist
				{
                    count++;
                    dict[s[i]] = count;
				}
				else
				{
                    dict.Add(s[i], 1);
				}
			}

            // order dictionary by descending order
            Dictionary<char, int> sortedDict = new Dictionary<char, int>();
            foreach(KeyValuePair<char, int> c in dict.OrderByDescending(key => key.Value))
			{
                sortedDict.Add(c.Key, c.Value);
			}


            // loop through the dictionary and add to a new array
            char[] newString = new char[s.Length];

            int startPos = 0;
            int initial = 0;
            foreach(KeyValuePair<char, int> c in sortedDict)
			{

                newString[startPos] = c.Key;
                if(c.Value > 0)
				{
                    for (int i = 1; i < c.Value; i++)
                    {
                        startPos = startPos + 2;
                        newString[startPos] = c.Key;
                    }
                }
                
                startPos = initial + 1;
			}

            string output = "";
            for(int i =0; i < newString.Length; i++)
			{
                output = output + newString[i];
			}


            return output;

		}






    }
}
