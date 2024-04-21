using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal struct Converter
    {
        public static string ToBinary(long number)
        {
            if (number == 0)
            {
                return "0";
            }

            string binaryString = "";
            while (number > 0)
            {
                binaryString = (number % 2) + binaryString;
                number /= 2;
            }

            return binaryString;
        }

        public static string ToOctal(long number)
        {
            if (number == 0)
            {
                return "0";
            }

            string octalString = "";
            while (number > 0)
            {
                octalString = (number % 8) + octalString;
                number /= 8;
            }

            return octalString;
        }

        public static string ToHexadecimal(long number)
        {
            if (number == 0)
            {
                return "0";
            }

            string hexString = "";
            while (number > 0)
            {
                hexString = (number % 16).ToString("X") + hexString;
                number /= 16;
            }

            return hexString;
        }
    }
}
