using System;

namespace Functional
{
    class FlipCoin
    {
        public void flipCoin()
        {
            Console.WriteLine("Enter number of times you want flip coin: ");
            int number = 0;
            while (number <= 0)
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            int head = 0;
            int tails = 0;
            Random random = new Random();
            for (int i = 0; i < number; i++)
            {
                if (random.NextDouble() > 0.5)
                    head++;
                else
                    tails++;
            }
            double head_percent = (head * 100) / number;
            double tail_percent = 100 - head_percent;
            Console.WriteLine("Head Percent: " + head_percent);
            Console.WriteLine("Tail Percent: " + tail_percent);
        }
    }
}
