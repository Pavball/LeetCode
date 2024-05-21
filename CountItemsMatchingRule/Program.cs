using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CountItemsMatchingRule
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IList<IList<string>> items = [["phone", "blue", "pixel"], ["computer", "silver", "phone"], ["phone", "gold", "iphone"]];

            string ruleKey = "type";
            string ruleValue = "phone";

            int count = CountMatches(items, ruleKey, ruleValue);

            Console.WriteLine(count);

        }

        public static int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            int count = 0;

            for (int i = 0; i < items.Count; i++)
            {
                
            switch (ruleKey)
            {
                case "type":

                            if (items[i][0].Equals(ruleValue))
                            {
                                count++;
                            }
                        break;
                    case "color":
                            if (items[i][1].Equals(ruleValue))
                            {
                                count++;
                            }
                        break;
                case "name":
                            if (items[i][2].Equals(ruleValue))
                            {
                                count++;
                            }
                        break;
                default:
                    // code block
                    break;
            }

            }


            return count;
        }
    }
}
