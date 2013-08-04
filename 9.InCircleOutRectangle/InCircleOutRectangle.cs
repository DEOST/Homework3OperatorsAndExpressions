//Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.InCircleOutRectangle
{
    class InCircleOutRectangle
    {
        static void Main()
        {
            Console.WriteLine("Type a x coordinate of point");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a y coordinate of point");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a x coordinate of center of circle");
            int centerX = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a y coordinate of center of circle");
            int centerY = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a radius of circle");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a x coordinate of left side of rectangle");
            int leftRectangle = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a y coordinate of top side of rectangle");
            int topRectangle = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a width of rectangle");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a height of rectangle");
            int height = int.Parse(Console.ReadLine());
            bool inCircle = (((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY)) <= radius * radius);
            bool outRectangle = ((x<leftRectangle)||(x>(leftRectangle+width))||(y>topRectangle)||(y<(topRectangle-height)));
            Console.WriteLine(inCircle ? "The point is in the circle" : "The point is out of the circle");
            Console.WriteLine(outRectangle ? "The point is out of the rectangle" : "The point is in of the rectangle");
            Console.WriteLine("The point corespond with the conditions " + (inCircle&&outRectangle));
        }
    }
}
