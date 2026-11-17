using System;
using System.Collections.Generic;
using System.Text;

namespace ifelseif
{
    internal class doWhileLoop
    {
        internal void dwLoop()
        {
            int n = 0;
            do
            {
                Console.WriteLine(n);
                n++;

            }
            while (n <= 10);
            Console.WriteLine("Do while loop terminates");
        }
    }
}
