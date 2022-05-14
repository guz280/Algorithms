using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public static class RomanNumbers
	{
        // https://leetcode.com/problems/roman-to-integer/
        //I can be placed before V (5) and X (10) to make 4 and 9. 
        // X can be placed before L(50) and C(100) to make 40 and 90. 
        // C can be placed before D(500) and M(1000) to make 400 and 900.
        public static int RomanToInt(string s)
        {
            int sum = 0;
            Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                char currentRomanChar = s[i];
                romanNumbersDictionary.TryGetValue(currentRomanChar, out int num);

                if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[currentRomanChar])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }


            }

            return sum;
        }

        public static int RomanToInt_JC(string s)
        {
            Dictionary<char, int> romanNumbersDictionary = new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };



            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                //char currentRomanChar = s[i];
                romanNumbersDictionary.TryGetValue(s[i], out int num);
                if (i + 1 < s.Length && romanNumbersDictionary[s[i + 1]] > romanNumbersDictionary[s[i]])
                {
                    sum -= num;
                }
                else
                {
                    sum += num;
                }
            }
            return sum;
        }


        
    }
}
