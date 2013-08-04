//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Divide5And7
{
    class Divide5And7
    {
        static void Main()
        {
            Console.WriteLine("Type a number");
            int checkNum = int.Parse(Console.ReadLine());
            bool result = checkNum % (7 * 5) == 0;
            Console.WriteLine("The number {0} can divided by 7 and 5 at the same time {1}", checkNum, result);
        }
    }
}
