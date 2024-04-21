using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = [0, 1, 2, 2, 3, 0, 4, 2]; 
            int val = 2; 

            int k = RemoveElement(nums, val);

        }


        public static int RemoveElement(int[] nums, int val) {

            int numOfEl = 0;
            int constant = 999;
        

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == val)
                {
                    
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        nums[j - 1] = nums[j];
                    }

                    // set the last element to zero
                    nums[nums.Length - 1] = constant;

                    i--;
                }


            }

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] != constant)
                {
                    numOfEl++;
                }


            }


            Console.Write("Starting array: ");
            for (int j = 0; j < nums.Length; j++)
            {
                Console.Write(nums[j] + " ");   
            }

            Console.Write("\nSize of ending array: " +  numOfEl + " ");
   
            return numOfEl; 
        
        }
    }
}
