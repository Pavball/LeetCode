using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunningSumOfArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] startArray = [1, 1, 1, 1, 1];

            int[] runningSum = RunningSum(startArray);

            foreach (var item in runningSum)
            {
                
                Console.WriteLine(item);

            }

        }


        public static int[] RunningSum(int[] nums)
        {
            int[] runningSum = new int[nums.Length];
            int sum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                
                sum += nums[i];
                runningSum[i] = sum;
            }



            return runningSum;
        }
    }
}
