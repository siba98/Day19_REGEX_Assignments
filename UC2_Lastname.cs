using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_REGEX_Assignments
{
    class UC2_Lastname
    {
        public static string Regex_Lastname = "^[A-Z]{1}[a-z]{2,}$";

        public bool ValidateLastName(string lastname)
        {
            return Regex.IsMatch(lastname, Regex_Lastname);
        }
    }
}
