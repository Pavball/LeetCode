using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTheTemperature
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double temperature = 36.5;

            double[] arr = ConvertTemperature(temperature);

            foreach (var item in arr)
            {
                Console.WriteLine("Item: " + item);
            }
        }

        public static double[] ConvertTemperature(double celsius)
        {
            double[] doubles = new double[2];

            double kelvin = celsius + 273.15;
            double fahrenheit = celsius * 1.80 + 32.00;

            doubles[0] = kelvin;
            doubles[1] = fahrenheit;

            return doubles;
        }
    }
}
