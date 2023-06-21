﻿using System;
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
    }
}

