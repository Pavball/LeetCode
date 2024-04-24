using System;

namespace RemoveDuplicatesSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int[] nums = [1, 1, 2];
            int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];

            int k = RemoveDuplicates(nums);

        }


        public static int RemoveDuplicates(int[] nums)
        {
            int currentUniqueNum = nums[0];
            int idx = 1;

            for (int i = 1; i < nums.Length; i++)
            {

                if (nums[i] != currentUniqueNum)
                {
                    currentUniqueNum = nums[i];
                    nums[idx] = currentUniqueNum;
                    idx++;
                }
               

            }

            //PROVJERA ARRAYA I BROJA UNIQUE NUMBER-a

            Console.Write("Ending array: ");

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }

            Console.Write("\nNumber of unique numbers: " + idx);
            Console.Write("\n");


            //vraca broj unique-a
            return idx;

        }
    }
}
