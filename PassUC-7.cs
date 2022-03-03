using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class PassUC_7
    {
        public static string REGEX_Password = "^[A-Za-z0-9]{8,}$";

        public bool validPasswordRule3(string Password)
        {
            return Regex.IsMatch(Password, REGEX_Password);
        }
    }
}
