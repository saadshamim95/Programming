//-----------------------------------------------------------------------
// <copyright file="LateBinding.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern.Reflection
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Class for Late Binding using Reflection
    /// </summary>
    public class LateBinding
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();
            Type customerType = executingAssembly.GetType("Design_Pattern.Reflection.Customer");
            object customerInstance = Activator.CreateInstance(customerType);
            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = "Saad";
            parameters[1] = "Shamim";
            string fullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name: " + fullName);
        }
    }

    /// <summary>
    /// Customer Class
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Gets the full name.
        /// </summary>
        /// <param name="firstName">The first name.</param>
        /// <param name="lastName">The last name.</param>
        /// <returns>It returns string</returns>
        public string GetFullName(string firstName, string lastName)
        {
            return firstName + " " + lastName;
        }
    }
}