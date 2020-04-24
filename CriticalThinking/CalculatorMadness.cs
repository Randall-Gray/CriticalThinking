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
        public int AddTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne + numberTwo;
            return result;
        }
        public int SubtractTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne - numberTwo;
            return result;
        }
        public int MultiplyTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne * numberTwo;
            return result;
        }
        public int DivideTwoNumbers(int numberOne, int numberTwo)
        {
            int result = numberOne / numberTwo;
            return result;
        }

        public void RunCalculations()
        {
            int output = AddTwoNumbers(SubtractTwoNumbers(AddTwoNumbers(6, 5), DivideTwoNumbers(MultiplyTwoNumbers(40 , 35), 4)), MultiplyTwoNumbers(2, 2));
            Console.WriteLine("The result is: " + output);
        }
    }
}
