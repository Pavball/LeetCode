using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string s = "IV";
            int num;
            num = RomanToInt(s);

            Console.WriteLine(num);


        }

        public static int RomanToInt(string s)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>(){
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i < s.Length - 1 && romanValues[s[i]] < romanValues[s[i + 1]])
                {
                    result -= romanValues[s[i]];
                }
                else
                {
                    result += romanValues[s[i]];
                }
            }

            return result;
        }
    }
}
