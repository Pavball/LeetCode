using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAddedIntegerToArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = [2, 6, 4], nums2 = [9, 7, 5];


            int x = AddedInteger(nums1, nums2);

            Console.WriteLine(x);

        }

        public static int AddedInteger(int[] nums1, int[] nums2)
        {


            int x = 0;

            return x = nums2.Min() - nums1.Min();
        }
    }
}
