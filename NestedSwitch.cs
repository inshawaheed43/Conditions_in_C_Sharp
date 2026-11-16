using System;
using System.Collections.Generic;
using System.Text;

namespace ifelseif
{
    internal class NestedSwitch
    {

        internal void nestSwitch()
        {

            Console.WriteLine("Emter your pizza flavour");
            string pizza = Console.ReadLine();

            switch (pizza) {
                case "Fajita":
                    Console.WriteLine("You've selected fajita pizza flavor");
                    break;
                case "Tikka":
                    Console.WriteLine("You've selected fajita pizza Tikka");
                    break;
                case "Creamy Cheese":
                    Console.WriteLine("You've selected Creamy Cheese pizza flavor");
                    break;
                case "Vegetable Cheese":
                    Console.WriteLine("Enter your vegetable");
                    string veg = Console.ReadLine();
                    //Console.WriteLine("You've selected Vegetable Cheese pizza flavor");
                    switch (veg)
                    {
                        case "Capsicum":
                            Console.WriteLine("Ok, your Capsicum veg pizaa will be ready in minutes");
                            break;
                        case "Onion":
                            Console.WriteLine("Ok, your Onion veg pizaa will be ready in minutes");
                            break;
                        case "Jalpeno":
                            Console.WriteLine("Ok, your Jalpeno veg pizaa will be ready in minutes");
                            break;
                        case "Carrot":
                            Console.WriteLine("Ok, your Carrot veg pizaa will be ready in minutes");
                            break;
                        default:
                            Console.WriteLine("OOPS Sorry, That veg isn't available.");
                            break;
                    }
                    break;


                default:

                    Console.WriteLine("Pizza Not Available");
                    break;
            }


        }
    }
}
