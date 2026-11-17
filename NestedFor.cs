using System;
using System.Collections.Generic;
using System.Text;

namespace ifelseif
{
    internal class NestedFor
    {
        internal void nfLoop()
        {
            for (int i = 0; i <=3 ; i++)
            {

                Console.WriteLine("Hellow");

                for (int j = 0; j <=3 ; j++)
                {
                    Console.WriteLine("hey");
                    
                }
            }
            Console.ReadLine();
        }
    }
}
