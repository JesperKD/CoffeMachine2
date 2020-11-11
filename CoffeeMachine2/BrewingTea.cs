using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Class to brew tea on the machine
    /// </summary>
    public class BrewingTea : Ibrew
    {
        public void Brew(CoffeeMachine cm, Water w)
        {
            Console.WriteLine(cm.Brand + " is brewing " + w.cupsofwater + " cups of Tea.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(cm.Brand + " is done brewing your Tea.");
        }
    }
}
