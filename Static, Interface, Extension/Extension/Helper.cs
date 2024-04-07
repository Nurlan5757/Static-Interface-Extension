using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Static__Interface__Extension.Extension
{
    static class Helper
    {
        
        public static string ToCapitalize(this string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }

            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }

        public static string Capitalize(this string surname)
        {
            if (string.IsNullOrEmpty(surname))
            {
                return surname;
            }

            return surname.Substring(0, 1).ToUpper() + surname.Substring(1).ToLower();
        }



        internal static void IsOdd(int num)
        {
            Console.WriteLine(num % 2 != 0);
        }

        internal static void IsEven(int num)
        {
            Console.WriteLine(num % 2 == 0);
        }

        internal static bool HasDigit( this string txt)
        {
            return txt.Any(char.IsDigit);
        }

        public static bool CheckPassword(this string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit) && password.Length >= 8) 
            {
                return true;
            }
           return false;
        }

        public static string Capitalize(this string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return txt;
              
            }
            return char.ToUpper(txt[0]) + txt.Substring(1);



        }


    }
}
