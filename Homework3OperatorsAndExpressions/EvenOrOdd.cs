/*Write an expression that checks if given integer is odd or even.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3OperatorsAndExpressions
{
    class EvenOrOdd
    {
        static void Main()
        {
           Console.WriteLine("Type a number");
           int checkNum = int.Parse(Console.ReadLine());
           int mask = 1;
           int result = checkNum & mask; //ако последната цифра в бинарния израз е 0 - числото е четно, ако е 1 е нечетно.
           Console.WriteLine("The number {0} is {1}", checkNum, (result == 0 ? "even" : "odd"));
           //втори начин 
           Console.WriteLine("The number {0} is {1}", checkNum, (checkNum % 2 == 0 ? "even": "odd"));
        }
    }
}
