using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountPairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IList<int> nums = [-6, 2, 5, -2, -7, -1, 3];
            int target = -2;

            int i = 0;
            
            IList<int> sortedNums = nums.OrderBy(nums => nums).ToList();


            Console.Write("[");
            foreach (var item in sortedNums)
            {

                if (i < nums.Count - 1)
                {
                    Console.Write(item + ",");
                    i++;
                }
                else if(i == nums.Count - 1)
                {
                    Console.Write(item);
                }
                
            }
            Console.WriteLine("]");

            int countedPairs = CountPairs(sortedNums, target);


            Console.WriteLine("Counted pairs: " + countedPairs);

        }

        public static int CountPairs(IList<int> nums, int target)
        {
            int count = 0;
            int left = 0;
            int right = nums.Count - 1;

            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    // If sum is less than target, all pairs with nums[left] will also satisfy the condition
                    count += right - left;
                    left++;
                }
                else
                {
                    // If sum is greater than or equal to target, decrement right pointer
                    right--;
                }
            }

            return count;
        }

    }
}
