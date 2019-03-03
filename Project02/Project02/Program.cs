using System;

namespace Project02
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                int input = 0;
                Console.WriteLine("Area calulator");
                Console.WriteLine("------------------------------------------------------");
                Console.WriteLine("      1. Circle");
                Console.WriteLine("      2. Square");
                Console.WriteLine("      3. Rectangle");
                Console.WriteLine("      4. Rhombus");
                Console.WriteLine("      5. Parallelogram");
                Console.WriteLine("      6. Trapezoid");
                Console.WriteLine("     -1. Quit");

                input = Convert.ToInt32(Console.ReadLine());

                if (input == 1 || input == 2 || input == 3 || input == 4 || input == 5 || input == 6 || input == -1)
                {
                    switch (input)
                    {
                        case 1:
                            CalculateCircle();
                            input = 0;
                            break;

                        case 2:
                            CalculateSquare();
                            input = 0;
                            break;
                        case 3:
                            CalculateRectangle();
                            input = 0;
                            break;
                        case 4:
                            CalculateRhombus();
                            input = 0;
                            break;
                        case 5:
                            CalculateParallelogram();
                            input = 0;
                            break;
                        case 6:
                            CalculateTrapezoid();
                            input = 0;
                            break;
                        case -1:
                            Environment.Exit(0);
                            break;
                    }
                }
                else
                    Console.WriteLine("Invalid Numer try again");
            }
        }


        static private void CalculateCircle()
        {
            Console.WriteLine("Circle area calculator");
            Console.WriteLine("Enter circle radius or -1 to go to main menu");
            double radius = Convert.ToDouble(Console.ReadLine());
            if (radius == -1)
                return;
            Console.WriteLine("Radius you entered was: " + radius);
            Console.WriteLine("Area of the circle is " + (3.14 * radius *radius));
            Console.WriteLine("Press any key to exit");
            Console.Read();
            Environment.Exit(0);
        }

        static private void CalculateSquare()
        {
            Console.WriteLine("Square area calculator");
            Console.WriteLine("Enter length of one side or enter -1 to go to main menu");
            double side = Convert.ToDouble(Console.ReadLine());
            if (side == -1)
                return;
            Console.WriteLine("The length you entered: " + side);
            Console.WriteLine("Area of square is " + (side * side));
            Console.WriteLine("Press any key to exit");
            Console.Read();
            Environment.Exit(0);
        }

        static private void CalculateRectangle()
        {
            Console.WriteLine("Rectangle area calculator");
            Console.WriteLine("Enter length or press -1 to go to main menu");
            double l = Convert.ToDouble(Console.ReadLine());
            if (l == -1)
                return;
            Console.WriteLine("Enter Width or -1 to go to main menu");
            double w = Convert.ToDouble(Console.ReadLine());
            if (w == -1)
                return;
            Console.WriteLine("The length you enter: " + l + "\r\nThe width you entered: " + w);
            Console.WriteLine("The area of this rectangle: " + (l * w));
            Console.WriteLine("Press any key to exit");
            Console.Read();
            Environment.Exit(0);
        }

        static private void CalculateRhombus()
        {
            Console.WriteLine("Rhombus Area Calculator");
            Console.WriteLine("Enter the length of one diagonal or -1 to go to main menu");
            double l1 = Convert.ToDouble(Console.ReadLine());
            if (l1 == -1)
                return;
            Console.WriteLine("Enter the length of the second diagonal or -1 to go to main menu");
            double l2 = Convert.ToDouble(Console.ReadLine());
            if (l2 == -1)
                return;
            Console.WriteLine("The length of the first diagonal : " + l1 + "\r\nThe length of the second diagonal: " + l2);
            Console.WriteLine("The area of the rhombus: " + (  (l1*l2)/2)  );
            Console.WriteLine("Press any key to exit");
            Console.Read();
            Environment.Exit(0);
        }

        static private void CalculateParallelogram()
        {
            Console.WriteLine("Parallelogram Area Calcultor");
            Console.WriteLine("Enter the length of the base of the parallelogram or -1 to go to main menu");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b == -1)
                return;
            Console.WriteLine("Enter the length of the height of the parallelogram or -1 to go to main menu");
            double h = Convert.ToDouble(Console.ReadLine());
            if(h == -1)
                return;
            Console.WriteLine("The length of the base you entered: " + b + "\r\nThe height you entered: " + h);
            Console.WriteLine("The area of the parallelogram: " + (b*h) );
            Console.WriteLine("Press any key to exit");
            Console.Read();
            Environment.Exit(0);
        }

        static private void CalculateTrapezoid()
        {
            Console.WriteLine("Trapezoid area calculator");
            Console.WriteLine("Enter the length of the large base of the trapezoid or -1 to go to main menu");
            double lb = Convert.ToDouble(Console.ReadLine());
            if (lb == -1)
                return;
            Console.WriteLine("Enter the length of the small base of the trapezoid or -1 to go to main menu");
            double sb = Convert.ToDouble(Console.ReadLine());
            if (sb == -1)
                return;
            Console.WriteLine("Enter the height of the trapezoid or -1 to go to main menu");
            double h = Convert.ToDouble(Console.ReadLine());
            if (h == -1)
                return;
            Console.WriteLine("The length of the large base: " + lb
                + "\r\nThe length of the small base: " + sb
                + "\r\nThe length of the height: " + h);
            Console.WriteLine("The area of the trapezoid: " + ((lb + sb) * (h / 2)));
            Console.WriteLine("Press any key to exit");
            Console.Read();
            Environment.Exit(0);
        }
        

        }
        
        }
    

