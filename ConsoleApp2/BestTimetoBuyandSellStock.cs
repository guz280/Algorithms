using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	// https://www.geeksforgeeks.org/stock-buy-sell/
	// https://www.gyanblog.com/coding-interview/leetcode-solution-best-time-buy-sell-stock-1/#:~:text=You%20are%20given%20an%20array,can%20achieve%20from%20this%20transaction.
	public static class BestTimetoBuyandSellStock
	{
		// You are given an array prices where prices[i] is the price of a given stock on the ith day.
		// You want to maximize your profit by choosing a single day to buy one stock and choosing a
		// different day in the future to sell that stock.
		// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
		public static int MaxProfit(int[] prices)
		{
			// first we need to choose the lowest number
			// check position the lowest number is
			// if position at the end return 0

			// position of the lowest.
			// check for a higher number till the end of it

			//7, 1, 5, 3, 6, 4 put them in a dictionary (hash)

			// sort 1,3,4,5,6,7
			// select the first and get its position from dictionary

			// get the heighest value from sorted list.
			// check if its before or after the lowest value.
			// if it is before choose another one
			// if it is after its good.
			// sbtract them and return value

			Dictionary<int, int> dict = new Dictionary<int, int>();
			for (int i = 0; i < prices.Length; i++)
			{
				dict.Add(prices[i], i);
			}

			// sorted prices
			Array.Sort(prices);

			int lowestPrice = prices[0];



			dict.TryGetValue(lowestPrice, out int lowestPricePosition);



			for (int i = prices.Length - 1; i >= 0; i--)
			{
				int highestPrice = prices[i];
				dict.TryGetValue(highestPrice, out int highestPricePosition);

				if (lowestPricePosition < highestPricePosition)
				{
					return highestPrice - lowestPrice;
				}
			}

			return 0;
		}


		//Brute Force - O(n^2)
		public static int BruteForce(int[] prices)
		{
			int maxProfit = 0;

			for(int i = 0; i < prices.Length - 1; i ++)
			{
				for(int j = i+1; j < prices.Length; j++)
				{
					int diff = prices[j] - prices[i];
					if(diff > maxProfit)
					{
						maxProfit = diff;
					}
				}
			}
			return maxProfit;
		}


		//Better Solution O(n) 
		public static int MaxProfit_BetterSolution(int[] prices)
		{
			int maxProfit = 0;

			int minPrice = prices[0];

			for(int i = 0; i < prices.Length; i++)
			{
				maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
				minPrice = Math.Min(minPrice, prices[i]);
			}

			return maxProfit;
		}
	}
	

	
}
