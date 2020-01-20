//-----------------------------------------------------------------------
// <copyright file="PrototypeMain.cs" company="BridgeLabz">
//     Copyright © 2020 Company="BridgeLabz"
// </copyright>
// <creator name="Saad Shamim"/>
//-----------------------------------------------------------------------

namespace Design_Pattern
{
    using System;

    /// <summary>
    /// Class for testing Prototype Design Pattern
    /// </summary>
    public class PrototypeMain
    {
        /// <summary>
        /// Tests this instance.
        /// </summary>
        public void Test()
        {
            Developer dev = new Developer();
            dev.Name = "Saad";
            dev.Role = "Software Developer";
            dev.PreferredLanguage = "C#";

            Developer devCopy = (Developer)dev.Clone();
            devCopy.Name = "Mayank";

            Console.WriteLine(dev.GetDetails());
            Console.WriteLine(devCopy.GetDetails());

            Typist typist = new Typist();
            typist.Name = "Saad";
            typist.Role = "Typist";
            typist.WordsPerMinute = 120;

            Typist typistCopy = (Typist)typist.Clone();
            typistCopy.Name = "Mayank";

            Console.WriteLine(typist.GetDetails());
            Console.WriteLine(typistCopy.GetDetails());
        }
    }
}