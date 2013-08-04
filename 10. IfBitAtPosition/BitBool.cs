//Write a boolean expression that returns if 
//the bit at position p (counting from 0) in a 
//given integer number v has value of 1. Example: v=5; p=1  false
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.IfBitAtPosition
{
    class BitBool
    {
        static void Main()
        {
            Console.WriteLine("Type a number");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a position");
            int p = int.Parse(Console.ReadLine());
            int mask = 1<<p;
            int bit = (v & mask) >> p;
            bool result = bit == 1; 
            Console.WriteLine("The bit {0} of number {1} is 1 - {2}", p, v, result);
        }
    }
}
