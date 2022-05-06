using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public static class Fibonacci
	{
		public static int FibonacciDynamic(int n)
		{

			int []fib = new int[n + 2];

			fib[0] = 0;
			fib[1] = 1;

			for(int i = 2; i <= n; i++)
			{
				fib[i] = fib[i - 1] + fib[i - 2];
			}


			return fib[n];
		}

		public static int FibonacciRecursion(int n) //
		{
			if (n <= 1)
			{
				return n;
			}
			else // 0,1,2,3
			{
				return FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
			}
		}
	}
}
