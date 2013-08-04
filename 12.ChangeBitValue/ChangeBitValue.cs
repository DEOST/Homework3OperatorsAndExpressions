/*/We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to hold the value v at the position p from the binary representation of n.
	//Example: n = 5 (00000101), p=3, v=1  13 (00001101)
	n = 5 (00000101), p=2, v=0  1 (00000001)
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ChangeBitValue
{
    class ChangeBitValue
    {
        static void Main()
        {
            Console.Write("Type a number");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Type a position");
            int p = int.Parse(Console.ReadLine());
            Console.Write("Type a value (0/1) ");
            byte v = byte.Parse(Console.ReadLine());
            int mask = 1 << p;
            if (v == 0)
            {
                int result1 = (n & ~mask);
                Console.WriteLine(result1);
                string nBinary = Convert.ToString(n, 2);
                string maskBinary = Convert.ToString(mask, 2);
                string resultBinary = Convert.ToString(result1, 2);
                Console.WriteLine("{0,15} : n\n{1,15} : mask\n{2,15} : result", nBinary, maskBinary, resultBinary);
            }
            else
            {
                int result2 = (n | mask);
                Console.WriteLine(result2);
                string nBinary = Convert.ToString(n, 2);
                string maskBinary = Convert.ToString(mask, 2);
                string resultBinary = Convert.ToString(result2, 2);
                Console.WriteLine("{0,15} : n\n{1,15} : mask\n{2,15} : result", nBinary, maskBinary, resultBinary);
            }
        }
    }
}
