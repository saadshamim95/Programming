using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    class TemperatureConversion
    {
        /// <summary>
        /// Temperatures the conversion.
        /// </summary>
        public void temperatureConversion() {
            Console.WriteLine("1: Celsius to Fahrenheit");
            Console.WriteLine("2: Fahrenheit to Celsius");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter temperture value in Celsius: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = Utility.temperatureConversion(celsius, 'C');
                Console.WriteLine("Temperature in Fahrenheit: {0:0.00}", fahrenheit);
            }
            else if (choice == 2)
            {
                Console.Write("Enter temperture value in Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = Utility.temperatureConversion(fahrenheit, 'F');
                Console.WriteLine("Temperature in Celsius: {0:0.00}", celsius);
            }
            else {
                Console.WriteLine("Wrong Choice!");
            }
        }
    }
}
