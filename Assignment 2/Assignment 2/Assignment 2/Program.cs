using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            Boolean repeat = true;
            ConsoleKeyInfo key;

            while (repeat)
            {
                Console.WriteLine("Enter a radius to calculate");
                String rs =  Console.ReadLine();
                if (double.TryParse(rs, out r))
                {
                    Console.WriteLine("Area = " + (r * Math.PI * Math.PI));
                    while (true)
                    {
                        Console.WriteLine("Would you like to enter another number?");
                        key = Console.ReadKey();

                        if (key.KeyChar == 'y')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Let's run it back");
                            break;
                        }
                        else if (key.KeyChar == 'n')
                        {
                            Console.WriteLine("");
                            Console.WriteLine("Goodbye, press any key to exit");
                            repeat = false;
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Not a valid key");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid number");
                }
            }
        }
    }
}
