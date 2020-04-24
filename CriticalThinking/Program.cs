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
            string stringInput = "Hello World";

            for (int i = 0; i < stringInput.Length; i++)
            {
                if (i % 3 == 0)
                    Console.WriteLine(stringInput[i]);
            }
            Console.ReadLine();
        }
    }
}
