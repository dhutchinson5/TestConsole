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
            var number = new Random((int)DateTime.Now.Ticks).Next(0, 500);
            Console.WriteLine(number);
        }
    }
}
