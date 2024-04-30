using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindTheHighestAltitude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] gain = [-4, -3, -2, -1, 4, 3, 2];

            int maxAlt = LargestAltitude(gain);

            Console.WriteLine(maxAlt);
        }

        public static int LargestAltitude(int[] gain)
        {
            int[] altitudeArray = new int[gain.Length + 1];

            //altitudeArray[0] will always be 0
            altitudeArray[0] = 0;

            int gainIdx = 0;
            //Set AltitudeArray before calculating Changes
            for (int i = 1; i < altitudeArray.Length; i++) {

                altitudeArray[i] = gain[gainIdx];
                gainIdx++;

            }

            //Calculate Altitude Changes
            for (int i = 1; i < altitudeArray.Length; i++)
            {

                altitudeArray[i] = altitudeArray[i-1] + altitudeArray[i];

            }

            int maxAlt = altitudeArray.Max();

            return maxAlt;
        }

    }
}
