using System;

namespace Algorithm
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("1: Anagram Detection");
            Console.WriteLine("2: Prime Numbers between 0-1000");
            Console.WriteLine("3: Prime Numbers that are Anagram or Palindrome (0-1000)");
            Console.WriteLine("4: Utility Class");
            Console.WriteLine("5: Find Number");
            Console.WriteLine("6: Binary Search");
            Console.WriteLine("7: Insertion Sort");
            Console.WriteLine("8: Bubble Sort");
            Console.WriteLine("9: Merge Sort");
            Console.WriteLine("10: Vending Machine");
            Console.WriteLine("11: Day of Week");
            Console.WriteLine("12: Temperature Conversion");
            Console.WriteLine("13: Monthly Payment");
            Console.WriteLine("14: Square Root");
            Console.WriteLine("15: To Binary");
            Console.WriteLine("16: Binary Swap Nibbles");
            int choice = 0;
            while (!(choice > 0 && choice < 17))
            {
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
            switch (choice) {
                case 1:
                    AnagramDetection anagramDetection = new AnagramDetection();
                    anagramDetection.anagram();
                    break;
                case 2:
                    PrimeNumbers primeNumbers = new PrimeNumbers();
                    primeNumbers.prime();
                    break;
                case 3:
                    PrimeAnagramPalindrome primeAnagramPalindrome = new PrimeAnagramPalindrome();
                    primeAnagramPalindrome.checkForPrimeAnagramPalindrome();
                    break;
                case 4:
                    int[] integerArray = { 10, 8, 7, 4, 3, 5, 0, 1, 2, 6, 9 };
                    integerArray = Utility.BubbleSort(integerArray);
                    Console.WriteLine("After Bubble Sort:");
                    for (int i = 0; i < integerArray.Length; i++) {
                        Console.Write(integerArray[i] + " ");
                    }
                    Console.WriteLine();
                    int pos1 = Utility.BinarySearch(6, 0, 11, integerArray);
                    if (pos1 == -1)
                        Console.WriteLine("Not Found!");
                    else
                        Console.WriteLine("Found at location: " + pos1);

                    Console.WriteLine();

                    string[] stringArray = { "saad", "fahad", "saba", "zeeshan", "ashhar", "owais" };
                    stringArray = Utility.BubbleSort(stringArray);
                    Console.WriteLine("After Bubble Sort:");
                    for (int i = 0; i < stringArray.Length; i++)
                    {
                        Console.Write(stringArray[i] + " ");
                    }
                    int pos2 = Utility.BinarySearch("saad", 0, 11, stringArray);
                    Console.WriteLine();
                    if (pos2 == -1)
                        Console.Write("Not Found!");
                    else
                        Console.Write("Found at location: " + pos2);
                    break;
                case 5:
                    FindingNumber findingNumber = new FindingNumber();
                    findingNumber.Find();
                    break;
                case 6:
                    BinarySearch search = new BinarySearch();
                    search.binarySearch();
                    break;
                case 7:
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Sort();
                    break;
                case 8:
                    BubbleSort bubbleSort = new BubbleSort();
                    bubbleSort.Sort();
                    break;
                case 9:
                    MergeSort mergeSort = new MergeSort();
                    mergeSort.Sort();
                    break;
                case 10:
                    VendingMachine vendingMachine = new VendingMachine();
                    vendingMachine.machine();
                    break;
                case 11:
                    DayOfWeek dayOfWeek = new DayOfWeek();
                    dayOfWeek.getDay();
                    break;
                case 12:
                    TemperatureConversion conversion = new TemperatureConversion();
                    conversion.temperatureConversion();
                    break;
                case 13:
                    MonthlyPayment monthlyPayment = new MonthlyPayment();
                    monthlyPayment.payment();
                    break;
                case 14:
                    SquareRoot root = new SquareRoot();
                    root.calculateSquareRoot();
                    break;
                case 15:
                    ConvertToBinary convert = new ConvertToBinary();
                    convert.conversion();
                    break;
                case 16:
                    BinarySwapNibbles binarySwapNibbles = new BinarySwapNibbles();
                    binarySwapNibbles.swapNibbles();
                    break;
                default:
                    Console.WriteLine("Wrong Choice!");
                    break;
            }
        }
    }
}