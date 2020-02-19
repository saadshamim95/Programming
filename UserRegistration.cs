using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace XUnitTesting
{
    class UserRegistration
    {
        public bool FirstName(string firstName)
        {
            var pattern = "^[a-zA-Z]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(firstName))
            {
                return true;
            }

            return false;
        }

        public bool LastName(string lastName)
        {
            var pattern = "^[a-zA-Z]+$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(lastName))
            {
                return true;
            }

            return false;
        }
    }
}