using System;
using System.Text.RegularExpressions;

namespace Object_Oriented
{
    class RegularExpression
    {
        public void checkExpression() {
            string text = "Hello <<name>>," +
                "\nWe have your full name as <<full name>> in our system. Your contact number is 91-xxxxxxxxxx." +
                "\nPlease, let us know in case of any clarification." +
                "\n\nThank you" +
                "\nBridgeLabz xx/xx/xxxx";
            string patternName = "<<name>>";
            string patternFullName = "<<full name>>";
            string patternNumber = "xxxxxxxxxx";
            string patternDate = "xx/xx/xxxx";

            Console.Write("Enter your First Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your Full Name: ");
            string fullName = Console.ReadLine();
            Console.Write("Enter your Mobile number: ");
            string number = Console.ReadLine();
            if (!Regex.IsMatch(name, "^[a-zA-Z]*$") ||
                !Regex.IsMatch(fullName, "^[a-zA-Z]+[ ]{1}[a-zA-Z]+$") ||
                !Regex.IsMatch(number, "^[0-9]{10}$"))
            {
                Console.WriteLine("Invalid Input!!!");
            }
            else
            {
                text = replacePattern(text, name, patternName);
                text = replacePattern(text, fullName, patternFullName);
                text = replacePattern(text, number, patternNumber);
                string date = DateTime.Now.ToString("MM/dd/yyyy");
                text = replacePattern(text, date, patternDate);
                Console.WriteLine(text);
            }
        }

        public string replacePattern(string text, string check,string pattern) {
            Regex regex = new Regex(pattern);
            string newString = regex.Replace(text, check);
            return newString;
        }
    }
}