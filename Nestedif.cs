using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ifelseif
{
    internal class Nestedif
    {

        internal void nestIf()
        {
            int a = 8;



            if (a > 5)
            {
                if (a == 10)
                {
                    Console.WriteLine("A is 10.....");
                }
                else
                {
                    Console.WriteLine("a is not 10......");
                }
            }




            else
            {
                Console.WriteLine("A is lesser.....");

                if (a == 3)
                {
                    Console.WriteLine("A is 3");

                }
                else
                {
                    Console.WriteLine("A is not 3");
                }
            }

            Console.ReadLine();

        }



        internal void email()
        {


            Console.WriteLine("Enter your Email ");
            string email = Console.ReadLine();
            if (email == "waheedinsha02@gmail.com")
            {
                Console.WriteLine("Ok, Good Now write your Password:");
                String password = Console.ReadLine();
                if (password == "Insha321")
                {
                    Console.WriteLine("Login Successfull");
                }
                else
                {
                    Console.WriteLine("Invalid Password");
                }

            }
            else
            {
                Console.WriteLine("Invalid Email");
            }
        }
    }
}
