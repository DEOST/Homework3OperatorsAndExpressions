//Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.IfThirdBit0
{
    class IfThirdBit
    {
        static void Main()
        {
            Console.WriteLine("Type a number");
            int checkNum = int.Parse(Console.ReadLine());
            int numBit = 3;
            int mask = 1<<numBit;
            bool result = (checkNum & mask)==0; //ако третата цифра в бинарния израз e 1 ще върне резултат "лъжа", ако е 0 - "истина".
            Console.WriteLine("The third bit of number {0} is {1}", checkNum, (result == true? "0" : "1"));
        }
    }
}
