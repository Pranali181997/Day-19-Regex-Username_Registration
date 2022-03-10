using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Day19_Regex
{
    public class RegexPattern
    {
        public static string firstName = "^[A-Z]{1}[a-z]{1,}$"; //UC-1

        public static string lastName = "^[A-Z]{1}[a-z]{1,}$";  //UC-2

        public static string eMail = "^[a-z]{2,}(.[a-z]{1,})?@[a-z]{1,}.[a-z]{1,}.[a-z]{1,}$"; //UC-3

        public static string mobileNoFormat = "^[/+]{1}[9]{1}[1]{1}[7-9]{1}[0-9]{9}$"; //UC-4

        public static string passwordFormat = "(?=.*[A-Z])(?=.*[0-9])(?=.*[!@#$%^&*()_+=-])[a-zA-Z0-9!@#$%^&*()_+=-]{8}$"; //UC-5 UC-6 UC-7

        //public static string passwordFormat = "^.*(?=.{8,})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=]).*$"; //UC-5 UC-6 UC-7 UC-8

        public static string eMail2 = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$";   //UC-9


        public void ValidatePasswordpasswordFormat(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, passwordFormat) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
        public void ValidateMobileNo(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, mobileNoFormat) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
        public void ValidateeMail(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, eMail2) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
        public void ValidatelastName(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, lastName) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
        public void ValidateFirstName(string[] names)
        {
            foreach (string n in names)
            {
                string result = Regex.IsMatch(n, firstName) ? $"{n} entered is valid" : $"{n} entered is Invalid";
                Console.WriteLine(result);
            }
        }
    }
}
