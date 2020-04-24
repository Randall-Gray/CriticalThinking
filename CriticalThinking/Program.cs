using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticalThinking
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorMadness calculator = new CalculatorMadness();
            calculator.RunCalculations();
            Console.ReadLine();
        }
    }
}
