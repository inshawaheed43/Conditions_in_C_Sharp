using System;
using System.Collections.Generic;
using System.Text;

namespace ifelseif
{
    internal class Ifelseif
    {

      internal void ifElseif()
        {
            Console.WriteLine("Enter your percentage");
            int percentage = int.Parse(Console.ReadLine());
            if (percentage >= 80)
            {
                Console.WriteLine("A+ Grade");
            }

            else if (percentage >= 60)
            {
                Console.WriteLine("B- Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }       
        }
    }
}
