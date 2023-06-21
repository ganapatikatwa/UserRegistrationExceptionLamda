using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class REGEX_Registration
    {
        //UC1
        public static string First_Name = "^[A-Z]{1}[a-z]{2,10}$";
        public bool ValidateFirstName(string sample)
        {
            return Regex.IsMatch(sample, First_Name);
        }
        //UC2
        public static string Last_Name = "^[A-Z]{1}[a-z]{2,10}$";

        public bool ValidateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, Last_Name);

        }
        //UC3

        public static string E_Mail = "^[A-Za-z]{3,}([.]{1}[A-Za-z]{3,})*[@][a-z]{2,}[.][a-z]{2,}([.][a-zA-Z]{2})?$";

        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email, E_Mail);

        }
        //UC4

        public static string PhNumber = "^91([ ])?[6-9]{1}[0-9]{9}$";

        public bool ValidatePhNumber(string sample)
        {
            return Regex.IsMatch(sample, PhNumber);

        }
    }
}

