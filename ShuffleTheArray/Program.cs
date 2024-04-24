using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShuffleTheArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*int[] nums = [2, 5, 1, 3, 4, 7];
            int n = 3;*/

            int[] nums = [1, 2, 3, 4, 4, 3, 2, 1];
            int n = 4;


            int[] arr = Shuffle(nums, n);



            //Output
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }

        public static int[] Shuffle(int[] nums, int n)
        {
            int[] endingNumsArray = new int[2 * n];
            int j = 0;
            int numsMiddle = nums.Length / 2;

            for (int i = 0; i < nums.Length; i++)
            {

                endingNumsArray[i] = nums[j];
                endingNumsArray[i + 1] = nums[numsMiddle + j];

                i++;
                j++;
            }

            return endingNumsArray;
        }
    }
}
