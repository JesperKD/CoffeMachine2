using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Interface for all classes that handle brewing
    /// </summary>
    interface Ibrew
    {
        void Brew(CoffeeMachine cm, Water w);
    }
}
