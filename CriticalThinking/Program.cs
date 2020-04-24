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
            Applications app;
            Computer computer = new Computer();

            app = new TextEditor("Word", "TextEditor", 4, 0.5);
            if (computer.motherboard.InstallApplication(app))
                Console.WriteLine("Word was installed okay");
            else
                Console.WriteLine("Word cannot be installed");

            app = new Games("DOOM", "1st person shooter", 4, 2, 2);
            if (computer.motherboard.InstallApplication(app))
                Console.WriteLine("DOOM was installed okay");
            else
                Console.WriteLine("DOOM cannot be installed");

            app = new Games("FortNite", "1st person shooter", 32, 200, 32);
            if (computer.motherboard.InstallApplication(app))
                Console.WriteLine("FortNite was installed okay");
            else
                Console.WriteLine("FortNite cannot be installed");

            Console.ReadLine();
        }
    }
}
