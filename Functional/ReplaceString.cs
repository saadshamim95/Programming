﻿using System;

namespace Functional
{
    class ReplaceString
    {
        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            string userName = "";
            while (userName.Length < 3)
            {
                Console.WriteLine("Enter UserName greater than 3 letter: ");
                userName = Console.ReadLine();
            }
            Console.WriteLine("Hello " + userName + ", How are you?");
        }
    }
}