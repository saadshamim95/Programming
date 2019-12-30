using System;

namespace Functional
{
    class TicTacToe
    {
        /// <summary>
        /// Determines whether the specified row is free.
        /// </summary>
        /// <param name="row">The row.</param>
        /// <param name="col">The col.</param>
        /// <param name="array">The array.</param>
        /// <returns>
        ///   <c>true</c> if the specified row is free; otherwise, <c>false</c>.
        /// </returns>
        public Boolean isFree(int row, int col, char[,] array) {
            if (array[row, col] == '-')
                return true;
            else
                return false;
        }

        /// <summary>
        /// Prints the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        public void Print(char[,] array) {
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Checks for win.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public Boolean checkForWin(char value, char[,] array) {
            //Row 1
            if (array[0, 0] == value && array[0, 1] == value && array[0, 2] == value)
                return true;
            //Row 2
            else if (array[1, 0] == value && array[1, 1] == value && array[1, 2] == value)
                return true;
            //Row 3
            else if (array[2, 0] == value && array[2, 1] == value && array[2, 2] == value)
                return true;
            //Col 1
            else if (array[0, 0] == value && array[1, 0] == value && array[2, 0] == value)
                return true;
            //Col 2
            else if (array[0, 1] == value && array[1, 1] == value && array[2, 1] == value)
                return true;
            //Col 3
            else if (array[0, 2] == value && array[1, 2] == value && array[2, 2] == value)
                return true;
            //Diagonol 1
            else if (array[0, 0] == value && array[1, 1] == value && array[2, 2] == value)
                return true;
            //Diagonol 2
            else if (array[2, 0] == value && array[1, 1] == value && array[0, 2] == value)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Games this instance.
        /// </summary>
        public void game() {
            char[,] array = new char[3, 3];
            bool user = false;
            bool win = false;
            int count = 0;
            for (int i = 0; i < 3; i++) {
                for (int j = 0; j < 3; j++) {
                    array[i, j] = '-';
                }
            }
            int row=-1;
            int col=-1;
            while (!win && count != 9) {
                bool accept;
                Random random = new Random();
                if (user == false)
                {
                    Console.WriteLine("Computer's Turn:");
                    accept = false;
                    while (!accept) {
                        row = (int)(random.NextDouble() * 3);
                        col = (int)(random.NextDouble() * 3);
                        accept = isFree(row, col, array);
                    }
                    array[row, col] = 'X';
                    user = true;
                    Print(array);
                    count++;
                    if (count > 4) {
                        win = checkForWin('X', array);
                        if (win)
                            Console.WriteLine("Computer has Won!");
                    }
                }
                else {
                    Console.WriteLine("User's Turn:");
                    accept = false;
                    while (!accept) {
                        row = Convert.ToInt32(Console.ReadLine());
                        col = Convert.ToInt32(Console.ReadLine());
                        accept = isFree(row, col, array);
                        if (!accept)
                            Console.WriteLine("Enter valid position:");
                    }
                    array[row, col] = 'O';
                    user = false;
                    Print(array);
                    count++;
                    if (count > 4) {
                        win = checkForWin('O', array);
                        if (win)
                            Console.WriteLine("User has Won!");
                    }
                }
            }
            if (win == false)
                Console.WriteLine("Match is Drawn!");
        }
    }
}