using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace SearchInsertPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [1, 3, 5, 6];
            int target = 0;

            int k = SearchInsert(nums, target);
            Console.WriteLine(k);
        }

        //SOLVED USING BINARY SEARCH (Divide and Conquer technique)
        public static int SearchInsert(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;
            int mid = 0;

            while (min <= max)
            {
                mid = (min + max) / 2;

                if (nums[mid] == target)
                {
                    return mid;
                }
                else if(target < nums[mid])
                {
                    max = mid - 1;

                }
                else
                {
                    min = mid + 1;
                }  

                
            }

            return ++max;

        }
    }
}
