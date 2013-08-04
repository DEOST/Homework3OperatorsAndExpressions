using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main()
        {

ArrayList generatePrimes(int toGenerate)
{
    ArrayList primes = new ArrayList();
    primes.Add(2);
    primes.Add(3);
    while (primes.Count < toGenerate)
    {
        int nextPrime = (int)(primes[primes.Count - 1]) + 2;
        while (true)
        {
            bool isPrime = true;
            foreach (int n in primes)
            {
                if (nextPrime % n == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                break;
            }
            else
            {
                nextPrime += 2;
            }
        }
        primes.Add(nextPrime);
    }
    return primes;
}
        }
    }
}
