//Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.CheckThirdDigit
{
    class CheckThirdDigit
    {
        static void Main()
        {
            Console.WriteLine("Type a number");
            int checkNum = int.Parse(Console.ReadLine());
            int result = (checkNum/100) % 10; //преместваме третата цифра накрая и като разделим на 10 взимаме остатъка, който всъщност е последната цифра
            Console.WriteLine("The third digit of given number is 7 is {0}", result == 7);//сравняваме със 7 и извеждаме резултата
        }
    }
}
