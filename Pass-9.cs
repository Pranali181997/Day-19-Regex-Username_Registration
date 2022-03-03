using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    class Pass_9
    {
        public static string REGEX_Email = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";

        public bool validEmail2(string Email)
        {
            return Regex.IsMatch(Email, REGEX_Email);
        }
    }
}
