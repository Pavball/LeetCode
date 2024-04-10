using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromNumber
{
    internal class Program
    {

        static void Main(string[] args)
        {
            bool isPalX;
            bool isPalY;
            int x = 10;
            int y = -121;

            isPalX = IsPalindrome(x);
            isPalY = IsPalindrome(y);

            Console.WriteLine(isPalX);
            Console.WriteLine(isPalY);

        }
        public static bool IsPalindrome(int x)
        {
            bool isPal = false;

            string word = x.ToString();

            Console.WriteLine(word);

            //Reversing string
            char[] stringArray = word.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);

            Console.WriteLine(reversedStr);

            //Checking if same
            if (word.Equals(reversedStr)) isPal = true;

            return isPal;
        }


    }


}
