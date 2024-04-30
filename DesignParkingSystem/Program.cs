using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignParkingSystem
{


    public class Program
    {
        int bigSpace;
        int mediumSpace;
        int smallSpace;

        public ParkingSystem(int big, int medium, int small)
        {
            this.bigSpace = big;
            this.mediumSpace = medium;
            this.smallSpace = small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 3)
            {
                smallSpace--;
                return this.smallSpace >= 0 ? true : false;
            }
            if (carType == 2)
            {
                mediumSpace--;
                return this.mediumSpace >= 0 ? true : false;
            }
            bigSpace--;
            return this.bigSpace >= 0 ? true : false;
        }

    }
}
