//-----------------------------------------------------------------------
// <copyright file="ExceptionHandling.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Class for Exception Handling
    /// </summary>
    public class ExceptionHandling
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            int i = 100;
            int j = 0;
            int result = 0;

            try
            {
                result = i / j;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide by Zero Exception");
            }
            finally
            {
                Console.WriteLine("Result: " + result);
            }
        }
    }
}