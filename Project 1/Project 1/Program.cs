using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            double[] nums = new double[args.Length];
            char op = 'n';

            if (args.Length > 0)
            {
                for (int x = 0; x < args.Length; x++)
                {
                    if (args[x] == "+" || args[x] == "-")
                    {
                        if(args[x] == "+")
                        {
                            op = 'a';
                        }
                        else if(args[x] == "-"){
                            op = 's';
                        }
                        Math(nums,op);
                        break;
                    }
                    else
                    {
                        nums[x] = Double.Parse(args[x]);
                    }
                    }
            }
            else
            {
                Console.WriteLine("No Arguments");

            }

            Console.WriteLine("Press any key to end....");
            Console.ReadLine();
        }

        static void Math(double [] nums, char op)
        {
            double num1 = nums[0];
            double total = num1;
            if (op == 'n')
            {
                Console.WriteLine("No operation found");
            }
            if(op == 's')
            {
                for(int y = 1; y < nums.Length; y++)
                {
                    total -= nums[y];
                }
                Console.WriteLine("Total is " + total);
            }
            else if (op == 'a')
            {
                for (int y = 1; y < nums.Length; y++)
                {
                    total += nums[y];
                }
                Console.WriteLine("Total is " + total);
            }
        }
        
    }
}
