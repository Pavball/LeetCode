using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numIdx = new int[2];

            //1st
            //int[] nums = [2, 7, 11, 15];
            //int target = 9;

            int[] nums = [3, 3];
            int target = 6;

            numIdx = TwoSumProblem(nums, target);

            foreach (var item in numIdx)
            {
                Console.WriteLine(item);
            }

        }

        public static int[] TwoSumProblem(int[] nums, int target)
        {
            int[] numberIdx = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (target == (nums[i] + nums[j]))
                    {
                        numberIdx[0] = i;
                        numberIdx[1] = j;
                        return numberIdx;
                    }
                }
            }

            return numberIdx;
        }
    }
}
