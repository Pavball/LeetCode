using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 1, 4, 1, 2 };
            int singleNumber = FindSingleNumber(nums);
            Console.WriteLine("The single number is: " + singleNumber);
        }

        static int FindSingleNumber(int[] nums)
        {
            int result = 0;

            // XOR all elements in the array
            foreach (int num in nums)
            {
                result ^= num;
            }

            return result;
        }

    }
}
