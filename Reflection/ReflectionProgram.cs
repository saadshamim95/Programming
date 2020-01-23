//-----------------------------------------------------------------------
// <copyright file="ReflectionProgram.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;
    using System.Reflection;

    /// <summary>
    /// Class for Reflection testing
    /// </summary>
    public class ReflectionProgram
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            Type T = Type.GetType("Design_Pattern.Customer");
            Console.WriteLine("Full Name: " + T.FullName);
            Console.WriteLine("Namespace: " + T.Namespace);
            Console.WriteLine("Class Name:" + T.Name);

            Console.WriteLine();
            Console.WriteLine("Properties of Customer Class:");
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType + " " + property.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Methods of Customer Class");
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                Console.WriteLine(method.ReturnType + " " + method.Name);
            }
        }
    }

    /// <summary>
    /// Customer Class
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
            this.Id = -1;
            this.Name = string.Empty;
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Prints the identifier.
        /// </summary>
        public void PrintID()
        {
            Console.WriteLine("ID = {0}" + this.Id);
        }

        /// <summary>
        /// Prints the name.
        /// </summary>
        public void PrintName()
        {
            Console.WriteLine("Name = {0}" + this.Name);
        }
    }
}