using System;
using System.Collections.Generic;
using System.Text;

namespace ifelseif
{
    internal class jumpStatements
    {
        internal void jState()
        {
            // TYPES OF JUMP STATEMENTS 
            //1. BREAK (IT USES WITH FOR LOOPS & SELECTION STATEMENTS)
            //2. CONTINUE 
            //3. GOTO 
            //4.RETURN 

            //break jump statements
            for (int i = 0; i < 10; i++)
            { 

                if(i == 5)
                {
                    break;
                }
                Console.WriteLine(i);
            }


            // continue jump statements


        }
    }
}
