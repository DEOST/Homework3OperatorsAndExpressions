//Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.IfPrimeNumber
{
    class Prime
    {
        static void Main()
        {
            Console.WriteLine("Type an n betwen 1 and 100");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int k=2; k < Math.Sqrt(n); k++)
                bool isPrimeNum = ((i % 2 > 0) && (i % 3 > 0) && (i % 5 > 0) && (i % 7 > 0))||(i == 2 || i == 3 || i== 5 || i==7 );
                Console.Write(isPrimeNum? (i + " is prime\n"):"");
            }
        }
    }
}
