using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_REGEX_Assignments
{
    class UC1_FirstName
    {
        public static string Regex_Firstname = "^[A-Z]{1}[a-z]{2,}$";

        public bool ValidateFirstName(string firstname)
        {
            return Regex.IsMatch(firstname, Regex_Firstname);
        }
    }
}
