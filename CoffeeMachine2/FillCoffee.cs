using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// class for filling the machine
    /// </summary>
    public class FillCoffee : Ifill
    {

        public void FillWithWater(CoffeeMachine cm, Water w)
        {
            Console.WriteLine(w.cupsofwater + " cups of water has been added to the " + cm.Brand);
        }

        public void FillWithTaste(CoffeeMachine cm, Taste t)
        {
            Console.WriteLine("CoffeeBeans has been added in the filter of the " + cm.Brand);
        }
    }
}
