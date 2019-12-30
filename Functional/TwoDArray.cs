using System;

namespace Functional
{
    class TwoDArray
    {
        public void input()
        {
            Console.WriteLine("1: Integers");
            Console.WriteLine("2: Doubles");
            Console.WriteLine("3: Booleans");
            Console.Write("Enter your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Rows: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of Columns: ");
            int col = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    int[,] integerArray = new int[row, col];
                    Console.WriteLine("Enter Array: ");
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            integerArray[i, j] = Convert.ToInt32(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < row; i++) {
                        for (int j = 0; j < col; j++) {
                            Console.Write(integerArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    double[,] doubleArray = new double[row, col];
                    Console.WriteLine("Enter Array: ");
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            doubleArray[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            Console.Write(doubleArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3:
                    bool[,] booleanArray = new bool[row, col];
                    Console.WriteLine("Enter Array: ");
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < col; j++)
                        {
                            String data = Console.ReadLine();
                            if (data.ToUpper().Substring(0,1).Equals("T"))
                                booleanArray[i, j] = true;
                            else if(data.ToUpper().Substring(0, 1).Equals("F"))
                                booleanArray[i, j] = false;
                        }
                    }
                    for (int i = 0; i < row; i++) {
                        for (int j = 0; j < col; j++) {
                            Console.Write(booleanArray[i,j]+" ");
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Wrong Choice!");
                    break;
            }
        }
    }
}
