using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day19_REGEX_Assignments
{
    class UC3_9_Email
    {
        //^[a-zA-Z0-9]+ --> Starts with Letters and Numbers(At least one char is required)
        //([.#_$+-][a-zA-Z0-9]+)* -->for 1st optional part
        //[@] --> Followed by @
        //[a-zA-Z0-9]+ --> should have Alphabets and Numbers(At least one char is required)
        //[.] --> followed by .
        //[a-zA-Z]{2-3] --> only aphabets and no numbers and max 3
        //([.][a-zA-z0-9]{2})? --> for 2nd optional part

        public static string Regex_Email = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Regex_Email);
        }
    }
}
