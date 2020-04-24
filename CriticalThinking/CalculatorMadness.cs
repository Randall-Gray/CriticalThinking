using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class CalculatorMadness
    {
        // Member variables

        // constructor

        // Member methods
        public void AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            Console.WriteLine("The result of this addtion is: " + result);
        }

        public void RunCalculations()
        {
            AddTwoNumbers(5, 7);
        }
    }
}
