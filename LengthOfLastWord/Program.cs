using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "   fly me   to   the moodsadn  ";

            int k = LengthOfLastWord(s);

            Console.WriteLine(k); 
        }

        public static int LengthOfLastWord(string s)
        {
            // Trim any leading or trailing whitespace
            s = s.Trim();

            // Find the index of the last space
            int lastIndex = s.LastIndexOf(' ');

            // If no space found, return the length of the whole string
            if (lastIndex == -1)
            {
                return s.Length;
            }

            // Otherwise, return the length of the substring after the last space
            return s.Length - lastIndex - 1;
        }
    }
}
