using System;

namespace Functional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: Replace String");
            Console.WriteLine("2: FlipCoin");
            Console.WriteLine("3: Leap Year");
            Console.WriteLine("4: Power of 2");
            Console.WriteLine("5: Harmonic Number");
            Console.WriteLine("6: Prime Factors");
            Console.WriteLine("7: Gambler");
            Console.WriteLine("8: Coupon Numbers");
            Console.WriteLine("9: 2D Array");
            Console.WriteLine("10: Sum of Integer Zero");
            Console.WriteLine("11: Distance");
            Console.WriteLine("12: Permutations");
            Console.WriteLine("13: Stop Watch");
            Console.WriteLine("14: Tic-Tac-Toe");
            Console.WriteLine("15: Quadratic");
            Console.WriteLine("16: Wind Chill");
            int choice=0;
            while (!(choice > 0 && choice < 17)) {
                try
                {
                    Console.Write("Enter your choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    //Console.WriteLine(Ex);
                }
            }
            
            //Console.WriteLine(choice);
            switch (choice)
            {
                case 1:
                    ReplaceString replaceString = new ReplaceString();
                    replaceString.Print();
                    break;
                case 2:
                    FlipCoin flip = new FlipCoin();
                    flip.flipCoin();
                    break;
                case 3:
                    LeapYear leap = new LeapYear();
                    leap.leapYear();
                    break;
                case 4:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.printPowerOfTwo();
                    break;
                case 5:
                    HarmonicNumber harmonic = new HarmonicNumber();
                    harmonic.printHarmonicNumber();
                    break;
                case 6:
                    Factors factors = new Factors();
                    factors.printFactors();
                    break;
                case 7:
                    Gambler gambler = new Gambler();
                    gambler.gambling();
                    break;
                case 8:
                    CouponNumbers coupon = new CouponNumbers();
                    coupon.CouponCode();
                    break;
                case 9:
                    TwoDArray array = new TwoDArray();
                    array.input();
                    break;
                case 10:
                    SumZero sumZero = new SumZero();
                    sumZero.checkSumForZero();
                    break;
                case 11:
                    Distance distance = new Distance();
                    distance.calculateDistance();
                    break;
                case 12:
                    Permutations permutations = new Permutations();
                    permutations.permutation();
                    break;
                case 13:
                    StopWatch watch = new StopWatch();
                    watch.simulate();
                    break;
                case 14:
                    TicTacToe ticTacToe = new TicTacToe();
                    ticTacToe.game();
                    break;
                case 15:
                    Quadratic quadratic = new Quadratic();
                    quadratic.roots();
                    break;
                case 16:
                    WindChill windChill = new WindChill();
                    int t = 100;
                    int v = 0;
                    while (!(Math.Abs(t) <= 50 && v <= 120 && v >= 3))
                    {
                        Console.WriteLine("Enter Temperature and Wind Speed: ");
                        t = Convert.ToInt32(Console.ReadLine());
                        v = Convert.ToInt32(Console.ReadLine());
                    }
                    windChill.effectiveTemperature(t, v);
                    break;
                default:
                    Console.WriteLine("Wrong Choice!");
                    break;
            }
        }
    }
}