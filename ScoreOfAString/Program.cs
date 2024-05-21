using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreOfAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "hello";

            int score = ScoreOfString(s);

            Console.WriteLine(score);
        }

        public static int ScoreOfString(string s)
        {
            int score = 0;

            List<char> list = new List<char>();
           

            list = s.ToCharArray().ToList();

            int[] stringValueArray = new int[list.Count];

            for (int i = 0; i < stringValueArray.Length; i++)
            {
                stringValueArray[i] = System.Convert.ToInt32(list[i]);
                Console.WriteLine(i + ": " + stringValueArray[i] + " Letter: " + list[i]);  
            }

            Console.WriteLine("");
            int helpIdx = 0;

            for (int i = 1; i < stringValueArray.Length; i++)
            {
                helpIdx = i;
                score += Math.Abs(stringValueArray[helpIdx - 1] - stringValueArray[i]);
                Console.WriteLine("Current score: " + score);
            }



            return score;
        }
    }
}
