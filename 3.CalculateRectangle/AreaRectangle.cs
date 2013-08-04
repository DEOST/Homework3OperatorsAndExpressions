//Write an expression that calculates rectangle’s area by given width and height.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.CalculateRectangle
{
    class AreaRectangle
    {
        static void Main()
        {
            checked
            {
                Console.WriteLine("Type a width of rectangle ");
                decimal width = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Type a height of rectangle");
                decimal height = decimal.Parse(Console.ReadLine());
                Console.WriteLine("The area of the rectangle with width {0} and height {1} is: {2}", width, height, width * height);
            }
        }
    }
}
