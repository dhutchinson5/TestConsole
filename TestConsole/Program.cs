using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generate Random Number
            var number = new Random((int)DateTime.Now.Ticks).Next(0, 500);
            // Write Random Number
            Console.WriteLine(number);
        }
    }
}
