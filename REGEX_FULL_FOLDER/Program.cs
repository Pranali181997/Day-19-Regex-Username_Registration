using System;

namespace Day19_Regex
{
    class Program
    {

        static void Main(string[] args)
        {
            RegexPattern userRegistrationPattern = new RegexPattern();
            string[] checkingFirstNames = { "Pranali" , "Kaush"};
            string[] checkingLastNames = { "Jambat", "Lambat" };
            string[] checkingEMails = { "abc@bl.co", "abc.@bl.co","abc.xyz@bl.co", "abc.xyz@bl.co.in"  };
            string[] checkingNo = { "+919486251122","+919632584333" };
            string[] checkingPassword = { "2658H@SKJa", "GaHi@M1j", "Fsjk@M6s", "fr@xdFffA8" };
            string[] checkingEmails2 = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" };
            userRegistrationPattern.ValidateFirstName(checkingFirstNames);
            userRegistrationPattern.ValidatelastName(checkingLastNames);
            userRegistrationPattern.ValidateeMail(checkingEMails);
            userRegistrationPattern.ValidateMobileNo(checkingNo);
            userRegistrationPattern.ValidatePasswordpasswordFormat(checkingPassword);
            userRegistrationPattern.ValidateeMail(checkingEmails2);
        }
    }
}