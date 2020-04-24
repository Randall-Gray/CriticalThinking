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

        public void RunCalculations()
        {
            Console.WriteLine("Enter first number to add: ");
            int value1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number to add: ");
            int value2 = int.Parse(Console.ReadLine());

            int output = AddTwoNumbers(value1, value2);
            Console.WriteLine("The result is: " + output);
        }
    }
}
