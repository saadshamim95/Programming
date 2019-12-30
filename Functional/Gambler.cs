using System;

namespace Functional
{
    class Gambler
    {
        public void gambling() {
            Console.Write("Enter the value of Stake: ");
            int stake = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the value of Goal: ");
            int goal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter number of times you want to play: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int num = 0;
            int wins = 0;
            while (stake != 0 && goal != stake && number != num)
            {
                Random random = new Random();
                if (random.NextDouble() >= 0.5)
                {
                    wins++;
                    stake++;
                }
                else
                    stake--;
                num++;
            }
            double win_percent = (wins * 100) / num;
            Console.WriteLine("Final Stake: " + stake);
            Console.WriteLine("Number of Wins: " + wins);
            Console.WriteLine("Win Percent: " + win_percent);
            Console.WriteLine("Loss Percent: " + (100 - win_percent));
        }
    }
}
