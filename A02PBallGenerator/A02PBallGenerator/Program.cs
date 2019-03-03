using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A02PBallGenerator
{
    class Program
    {
        static List<Int32> num = new List<Int32>();
        static int redBall = 0;
        static void Main(string[] args)
        {
            String letter = "y";

            
            do
            {
                num.Clear();
                GetNums();
                num.Sort();
                foreach(int number in num)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine("Redball is " + redBall);
                Console.WriteLine("Would you like to go again? y or n");
                letter = Console.ReadLine();
            }
            while (letter == "y");
        }


        public static void GetNums()
        {
            int rand;
            Random r = new Random();
            for (int x = 0; x < 6; x++)
            {
                do
                {
                    rand = r.Next(1, 70);
                } while (num.Contains(rand));
                num.Add(rand);
            }
           redBall = r.Next(1, 27);
        }
    }
}
