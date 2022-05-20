using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //https://leetcode.com/problems/number-of-provinces/

    //There are n cities. Some of them are connected, while some are not. If city a is connected directly with city b,
    //and city b is connected directly with city c, then city a is connected indirectly with city c.
    //A province is a group of directly or indirectly connected cities and no other cities outside of the group.
    //You are given an n x n matrix isConnected where isConnected[i][j] = 1 if the ith city and the jth city are directly
    //connected, and isConnected[i][j] = 0 otherwise.
    //Return the total number of provinces.

    public class NumberofProvinces
	{
        public int FindCircleNum(int[][] isConnected)
        {

            int count = 0;
            for (int i = 0; i < isConnected.Length; i++)
            {
                for (int j = 0; j < isConnected[i].Length; j++)
                {
                    count = count + Cities(isConnected, i, j);
                }
            }
            return count;
        }


        public int Cities(int[][] isConnected, int i, int j)
        {

            if (i < 0 || j < 0 || i >= isConnected.Length || j >= isConnected[i].Length || isConnected[i][j] == 0)
            {
                return 0;
            }



            isConnected[i][j] = 0;
            Cities(isConnected, i, j + 1);
            Cities(isConnected, i, j - 1);
            Cities(isConnected, i + 1, j);
            Cities(isConnected, i - 1, j);
            return 1; // if all processed return province found

        }
    }
}
