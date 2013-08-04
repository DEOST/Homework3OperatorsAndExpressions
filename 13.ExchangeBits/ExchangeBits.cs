//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ExchangeBits
{
    class ExchangeBits
    {
        static void Main()
        {
            Console.Write("Type a number");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
            for (int i = 3; i <= 5; i++)
            {
                for (int j = 24; j <= 26; j++)
                {
                    int mask = 1 << i;
                    int bit345 = (n & mask) >> i;
                    mask = 1 << j;
                    int bit24_25_26 = (n & mask) >> j;
                    if (bit345 == bit24_25_26)
                    {
                        Console.WriteLine(n);
                        return;
                    }
                    if (bit345 == 0)
                    {
                        mask = ~(1 << j);
                        n = n & mask;
                    }
                    else if (bit345 == 1)
                    {
                        mask = 1 << j;
                        n = n | mask;
                    }
                    if (bit24_25_26 == 0)
                    {
                        mask = ~(1 << i);
                        n = n & mask;
                    }
                    else if (bit24_25_26 == 1)
                    {
                        mask = 1 << i;
                        n = n | mask;
                    }
                }
            }
            Console.WriteLine(Convert.ToString(n, 2).PadLeft(32, '0'));
        }
    }
}
