using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extensions_Struct_Nullable_Practice.Helpers.Extensions
{
    public static class BaseExtensions
    {
        public static void ShowNum(this int num)
        {
            Console.WriteLine(num);
        }


        public static void ShowNum(this int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }


        public static int SumOfNums(this int num1, int num2)
        {
            return num1 + num2;
        }

        public static string ShowText(this string text, string str)
        {
            return text + " " + str;
        }


        public static bool CheckDigitForStr(this string str)
        {
            var res = Regex.IsMatch(str, @"/d");
            return res;
        }


        public static bool CheckEmail(this string str)
        {
            var res = Regex.IsMatch(str, "@");
            return res;
        }


        public static bool CheckStr(this string str, string pattern)
        {
            return Regex.IsMatch(str, pattern);
        }

        public static int FindFactorial(this int num)
        {
            var factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;

            }
            return factorial;
        }


        public static bool CheckEmailAndPassword(this string str,string pattern)
        {
            return Regex.IsMatch(str,pattern);
        }

        public static double PowOfNum(this int num,int pow)
        {
            return Math.Pow(num, pow);
        }

        public static bool IsConvertStringToNumber(this string str)
        {
            return int.TryParse(str, out var result);
        }
    }
}
