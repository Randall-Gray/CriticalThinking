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

            // Runs until the user enters the integer 42.
            // Runs at least once, could use a do{}while() loop instead.
            while (!validInput || counter != 42)
            {
                Console.WriteLine("Please enter the number 42 to run loop: ");
                validInput = int.TryParse(Console.ReadLine(), out counter);
                if (!validInput || counter != 42)
                    Console.WriteLine("WRONG!!! Please try again");
            }
            
            // with counter initially set to 42, loop won't run
            while (counter != 42)
            {
                counter++;
            }
        }
    }
}
