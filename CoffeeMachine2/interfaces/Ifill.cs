using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    /// <summary>
    /// Interface for fill classes
    /// </summary>
    interface Ifill
    {
        void FillWithWater(CoffeeMachine cm, Water w);

        void FillWithTaste(CoffeeMachine cm, Taste t);

    }
}
