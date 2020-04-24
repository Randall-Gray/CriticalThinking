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
            int counter = 0;
            bool validInput = false;

            // Make sure user enters an integer.
            while (!validInput)
            {
                Console.WriteLine("Enter number of times (integer) to run loop: ");
                validInput = int.TryParse(Console.ReadLine(), out counter);
            }
            
            // will iterate 25 - counter times.  Negative number makes it run more than 25 times.
            while (counter < 25)
            {
                counter++;
            }
        }
    }
}
