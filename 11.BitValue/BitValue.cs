//Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BitValue
{
    class BitValue
    {
        static void Main()
        {
            Console.WriteLine("Type a number");
            int i = int.Parse(Console.ReadLine());
            Console.WriteLine("Type a position");
            int b = int.Parse(Console.ReadLine());
            int mask = 1 << b;
            int bit = (i & mask) >> b;
            bool result = bit == 1;
            string numberBinary = Convert.ToString(i, 2);
            string maskBinary = Convert.ToString(mask, 2);
            string addMaskBinary = Convert.ToString((i & mask), 2);
            Console.WriteLine("{0,15} : i\n{1,15} : mask\n{2,15} : addMask", numberBinary, maskBinary, addMaskBinary);
            Console.WriteLine("The bit {0} of number {1} is {2}", b, i, bit);
        }
    }
}
