using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public static class ContinuousSubArray
	{
        // int[] arr = { 1, 2, 3, 7, 5 };
        //Given an unsorted array A of size N that contains only non-negative integers,
        //find a continuous sub-array which adds to a given number S.
        //In case of multiple subarrays, return the subarray which comes first on moving from left to right.
        public static List<int> SubarraySum(int[] arr, int n, int s)
        {
            //code here
            int sum = arr[0];
            int start = 0;
            List<int> resultList = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                // If curr_sum exceeds
                // the sum, then remove
                // the starting elements
                while (sum > s && start < i - 1)
                {
                    sum = sum - arr[start];
                    start++;
                }
                // If curr_sum becomes equal to
                // sum, then return true
                if (sum == s)
                {
                    resultList.Add(start + 1);
                    resultList.Add(i);
                    return resultList;
                }

                if (i < n)
                {
                    sum = sum + arr[i];
                }
            }
            return resultList;
        }
    }
}
