using System;

namespace Functional
{
    class Distance
    {
        /// <summary>
        /// Calculates the distance.
        /// </summary>
        public void calculateDistance() {
            Console.Write("Enter the value of X: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of Y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            double distance = Math.Sqrt((Math.Pow(x, 2)) + Math.Pow(y, 2));
            Console.WriteLine("Distance= " + distance);
        }
    }
}