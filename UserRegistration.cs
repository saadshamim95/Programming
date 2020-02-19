//-----------------------------------------------------------------------
// <copyright file="UserRegistration.cs" company="BridgeLabz">
//     Copyright © 2020 
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace XUnitTesting
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// class for User Registration
    /// </summary>
    public class UserRegistration
    {
        /// <summary>
        /// Firsts the name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <returns>It returns true if pattern matches.</returns>
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

        /// <summary>
        /// Lasts the name.
        /// </summary>
        /// <param name="lastName">The last name.</param>
        /// <returns>It returns true if pattern matches.</returns>
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

        /// <summary>
        /// Emails the specified email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns>It returns true if pattern matches.</returns>
        public bool Email(string email)
        {
            var pattern = "^([a-z0-9_.]+)@(gmail|outlook|yahoo).(com|co.in|gov|edu)$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(email))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Passwords the specified password.
        /// </summary>
        /// <param name="password">The password.</param>
        /// <returns>It returns true if pattern matches.</returns>
        public bool Password(string password)
        {
            var pattern = "(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&*!])(?=.{8,20})";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(password))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Mobiles the specified mobile.
        /// </summary>
        /// <param name="mobile">The mobile.</param>
        /// <returns>It returns true if pattern matches.</returns>
        public bool Mobile(string mobile)
        {
            var pattern = "^[0-9]{10}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(mobile))
            {
                return true;
            }

            return false;
        }
    }
}