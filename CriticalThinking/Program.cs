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
            int intInput = -1;
            bool validInput = false;

            while (!validInput || intInput < 0)
            {
                Console.WriteLine("Enter number of times (positive integer) to run loop: ");
                validInput = int.TryParse(Console.ReadLine(), out intInput);
            }
            for (int i = 0; i < intInput; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
