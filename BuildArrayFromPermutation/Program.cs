using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildArrayFromPermutation
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = [0, 2, 1, 5, 3, 4];

            int[] buildArray = BuildArray(nums);

            foreach (var item in buildArray)
            {
                Console.Write(item + " ");
            }

        }

        public static int[] BuildArray(int[] nums)
        {
            int[] buildArray = new int[nums.Length];


            for (int i = 0; i < nums.Length; i++)
            {

                buildArray[i] = nums[nums[i]];

            }


            return buildArray;
        }
    }
}
