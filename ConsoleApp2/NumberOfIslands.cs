using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    // https://leetcode.com/problems/number-of-islands/

   //Given an m x n 2D binary grid grid which represents a map of '1's (land) and '0's (water), return the number of islands.
   //An island is surrounded by water and is formed by connecting adjacent lands horizontally or vertically.
   //You may assume all four edges of the grid are all surrounded by water.

    public class NumberOfIslands
	{
        public int NumIslands(char[][] grid)
        {

            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    // count successfully processed islands
                    count += sink(grid, i, j);
                }
            }
            return count;

        }

        int sink(char[][] grid, int i, int j)
        {
            // if we are outside the grid i<0 || j<0 
            // or the current cell is visited  grid[i][j] == '0'
            // or we are at the bottom of the grid j == grid[i].Length
            // Not processed skip and return count 0 
            if (i < 0 || j < 0 || i >= grid.Length || j >= grid[i].Length || grid[i][j] == '0')
                return 0;
            // else process
            grid[i][j] = '0';  // sink current or turn current to visited
            sink(grid, i + 1, j); // sink right, do recursion as current
            sink(grid, i - 1, j); // sink left, do recursion as current
            sink(grid, i, j + 1); // sink down, do recursion as current
            sink(grid, i, j - 1); // sink up, do recursion as current
                                  // if all processed --> an island was found
            return 1;
        }

    }
}
