using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfEmployeesWhoMetTarget
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] hours = [0, 1, 2, 3, 4];
            int target = 2;

            int numberOfTarget = NumberOfEmployeesWhoMetTarget(hours, target);

            Console.WriteLine(numberOfTarget);
        }

        public static int NumberOfEmployeesWhoMetTarget(int[] hours, int target)
        {
            int numberOfTargetMeeters = hours.Count(employee => employee >= target);
            return numberOfTargetMeeters;
        }
    }
}
