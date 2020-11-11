using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Class that defines a water object
    /// </summary>
    public class Water
    {
        private int CupsofWater;

        public int cupsofwater
        {
            get { return CupsofWater; }
            set { CupsofWater = value; }
        }


        private int Temp;

        public int temp
        {
            get { return Temp; }
            set { Temp = value; }
        }
    }

}
