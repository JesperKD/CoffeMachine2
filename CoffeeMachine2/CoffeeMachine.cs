using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Class to define a coffeemachine object
    /// </summary>
    public class CoffeeMachine : Imachine
    {
        public string Brand { get; set; }

        public CoffeeMachine(string brand)
        {
            Brand = brand;
        }

        public void TurnOff()
        {
            Console.WriteLine("Turning off the machine");
        }

        public void TurnOn()
        {
            Console.WriteLine("Turning on the machine");
        }
    }
}
