using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsValid("()")); // Output: true
            Console.WriteLine(IsValid("()[]{}")); // Output: true
            Console.WriteLine(IsValid("(]")); // Output: false
            Console.WriteLine(IsValid("([)]")); // Output: false
            Console.WriteLine(IsValid("{[]}")); // Output: true

        }

        public static bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' && (stack.Count == 0 || stack.Pop() != '('))
                {
                    return false;
                }
                else if (c == '}' && (stack.Count == 0 || stack.Pop() != '{'))
                {
                    return false;
                }
                else if (c == ']' && (stack.Count == 0 || stack.Pop() != '['))
                {
                    return false;
                }
            }

            return stack.Count == 0;
        }
    }
}
