//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TrapezoidArea
{
    class TrapezoidArea
    {
        static void Main()
        {
            checked
            {
                Console.WriteLine("Type a side a");
                double sideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Type a side b");
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Type a height h");
                double height = double.Parse(Console.ReadLine());
                double area = (sideA + sideB) * height / 2;
                Console.WriteLine("Area of trapezoid is " + area);
            }
        }
    }
}
