using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ev
{
    class Program
    {
        static void Main(string[] args)
        {
            var pub = new Publisher("John");

            var sub = new Logger("Alice", pub);

            var worker = new Worker("Ben", pub);

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input.Trim()))
                {
                    break;
                }

                pub.Store(input);

                Console.WriteLine(sub);
            }
        }        
    }
}
