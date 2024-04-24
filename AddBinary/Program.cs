using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1010";
            string b = "1011";
            string addedString = AddBinary(a, b);

            Console.Write(addedString);

        }

        public static string AddBinary(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            int carry = 0;
            int i = a.Length - 1;
            int j = b.Length - 1;

            while (i >= 0 || j >= 0 || carry == 1)
            {
                if (i >= 0)
                {
                    carry += a[i--] - '0';
                }
                if (j >= 0)
                {
                    carry += b[j--] - '0';
                }
                sb.Append(carry % 2);
                carry /= 2;
            }

            return new string(sb.ToString().Reverse().ToArray());
        }
    }
  }

