using System;

namespace Functional
{
    class WindChill
    {
        /// <summary>
        /// Calculates the effective temperature.
        /// </summary>
        /// <param name="t">The t.</param>
        /// <param name="v">The v.</param>
        public void calculateEffectiveTemperature(int t, int v)
        {
            double w = 35.74 + 0.6215 * t + (0.4275 * t - 35.75) * Math.Pow(v, 0.16);
            Console.WriteLine("Effective Temperature: {0:0.00}", w);
        }
    }
}
