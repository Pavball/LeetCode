using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichestCustomerWealth
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[][] accounts = [[1, 2, 3], [3, 2, 1]];

            int[][] accounts2 = [[1, 5], [7, 3], [3, 5]];

            int[][] accounts3 = [[2, 8, 7], [7, 1, 3], [1, 9, 5]];

            int maxWealth = MaximumWealth(accounts3);

            Console.WriteLine(maxWealth);
        }

        public static int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;
            int sum = 0;
            int[] wealthArray = new int[accounts.Length]; 

            for (int i = 0; i < accounts.Length; i++)
            {
                for (int j = 0; j < accounts[i].Length; j++)
                {

                    sum += accounts[i][j];

                }

                wealthArray[i] = sum;
                sum = 0;
            }

            for (int i = 0; i < wealthArray.Length; i++)
            {

                if (wealthArray[i] >= maxWealth)
                {
                    maxWealth = wealthArray[i];
                }

            }



            return maxWealth;
        }
    }
}
