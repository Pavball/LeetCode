using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs1 = { "flower", "flow", "floight" };
            Console.WriteLine(LongestCommonPrefix(strs1)); // Output: "fl"

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];
            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0)
                        return "";
                }
            }

            return prefix;
        }
    }
}
