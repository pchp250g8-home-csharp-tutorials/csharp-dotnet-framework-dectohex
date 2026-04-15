using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecToHex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const uint MAX_INT = uint.MaxValue;
            Console.WriteLine("Input an unsigned integer number");
            var bIsRightNumber = (uint.TryParse(Console.ReadLine(), out var uNumber)) &&
                                 (uNumber <= MAX_INT);
            if (!bIsRightNumber)
            {
                Console.WriteLine("Invalid number format or number too big");
                Console.Read();
                return;
            }
            Console.WriteLine("Lower case ? (y/n)");
            var chAnswer = Console.Read();
            var bLowerCase = (chAnswer == 'y');
            var strHexNum = "";
            var uTempVal = uNumber;
            while (uTempVal > 0)
            {
                char chHexDigit = '\0';
                uint nHexDigit = uTempVal % 16;
                if (nHexDigit >= 0 && nHexDigit <= 9)
                    chHexDigit = (char)(nHexDigit + '0');
                else if (nHexDigit >= 10 && nHexDigit <= 15 && bLowerCase)
                    chHexDigit = (char)((nHexDigit - 10) + 'a');
                else if (nHexDigit >= 10 && nHexDigit <= 15)
                    chHexDigit = (char)((nHexDigit - 10) + 'A');
                strHexNum = chHexDigit + strHexNum;
                uTempVal /= 16;
            }
            if (strHexNum.Length == 0)
                strHexNum = "0";
            Console.WriteLine
            (
                "The hexadecimal equivalent of the decimal number {0} is: {1} ",
                uNumber, strHexNum
            );
            Console.Read();
        }
    }
}
