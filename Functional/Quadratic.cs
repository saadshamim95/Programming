using System;

namespace Functional
{
    class Quadratic
    {
        /// <summary>
        /// Rootses this instance.
        /// </summary>
        public void roots() {
            Console.Write("Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of c: ");
            int c = Convert.ToInt32(Console.ReadLine());
            int delta = b * b - 4 * a * c;
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Root 1: " + root1 + " Root2: " + root2);
        }
    }
}
