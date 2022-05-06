using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	public static class Sum
	{
        public static string Sum3(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                int sum = 0;
                int low = i + 1;
                int high = numbers.Length - 1;

                while (low < high)
                {
                    sum = numbers[i] + numbers[low] + numbers[high];

                    if (sum == target)
                    {
                        return (numbers[i] + " " + numbers[low] + " " + numbers[high]);
                    }
                    else if (sum < target)
                    {
                        low++;
                    }
                    else
                    {
                        high--;
                    }

                }

            }
            return string.Empty;
        }


        // https://www.youtube.com/watch?v=wq296uM_ShY
        public static string Sum2_Hash(int[] numbers, int target)
        {
            // can put in Dictionary
            //         Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            //         for(int i = 0; i < numbers.Length; i++)
            //{
            //             keyValuePairs.TryGetValue(numbers[i], out int exist);
            //             if(exist != numbers[i])
            //                 keyValuePairs.Add(numbers[i], numbers[i]);
            //}

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int low = numbers[i];
                int high = numbers.Length - 1;
                sum = low + high;

                int valueNeeded = target - low;
                // keyValuePairs.TryGetValue(valueNeeded, out int value);
                var value = Array.Find(numbers, element => element == valueNeeded);

                if (value != 0)
                {
                    return numbers[i] + " " + value;
                }
            }
            return string.Empty;

        }

    }
}
