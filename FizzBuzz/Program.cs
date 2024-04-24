using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = 15;

            IList<string> list = FizzBuzz(num);
        }

        public static IList<string> FizzBuzz(int n)
        {
            IList<string> list = new List<string>();

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    list.Add("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    list.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    list.Add("Buzz");
                }
                else
                {
                    list.Add(i.ToString());
                }

            }
            Console.Write("Answer array: ");
            foreach (var item in list)
            {
                Console.Write(item + ",");
            }
            Console.Write("\n");

            return list;

        }
    }
}
