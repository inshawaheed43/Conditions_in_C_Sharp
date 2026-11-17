using System;
using System.Collections.Generic;
using System.Text;

namespace ifelseif
{
    internal class forLoop
    {


        internal void fLoop()
        {

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("for loop terminates........");



            // for loop ke andr wala variable ap bahir use 
            //ni kr skte 

            //like: on line 30 it'ss give error if i wrote it like 
            // this: BUT 
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(1);
            //}
            //Console.WriteLine(i);}
            // WHEN WE WRITE IT LIKE THIS WE CAN USE 
            //VARIABLE OUTSIDE THE FOR LOOP 
            //int u;
            //for (u = 0; u >= 23; u++)
            //{
            //    Console.WriteLine(u);
            //}
            //Console.WriteLine(u);


        }
    }

}