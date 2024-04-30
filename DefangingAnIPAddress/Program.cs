using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefangingAnIPAddress
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string address = "1.1.1.1";

            string defangedAddress = DefangIPaddr(address);


            Console.WriteLine(defangedAddress);
        }

        public static string DefangIPaddr(string address)
        {

            return address.Replace(".", "[.]"); ;

        }
    }
}
