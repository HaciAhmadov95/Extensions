using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension.Helpers.Extensions
{
    public static class BaseExtension
    {
        public static bool HasSpaceInMiddle(this string email)
        {
            return email.IndexOf(' ') > email.IndexOf('@') && email.IndexOf(' ') < email.LastIndexOf('@');
        }



        public static int MultiplyElements(this int[] array)
        {
            int result = 1; 
            foreach (var item in array)
            {
                result *= item;
            }
            return result;
        }

        public static bool IsEmail(this string text)
        {
            return text.Contains("@");
        }



    }
}

