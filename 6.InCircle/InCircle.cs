//Write an expression that checks if given point (x,  y) 
//is within a circle K(O, 5).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.InCircle
{
    class InCircle
    {
        static void Main()
        {
            Console.WriteLine("Type a x coordinate");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a y coordinate");
            int y = int.Parse(Console.ReadLine());
            int centerX = 0;
            int centerY = 0;
            int radius = 5;
            bool result = (((x -centerX)* (x-centerX) + (y-centerY) * (y-centerY)) <= radius * radius);
            Console.WriteLine(result ? "The point is in the circle" : "The point is out of the circle");      
        }
    }
}
