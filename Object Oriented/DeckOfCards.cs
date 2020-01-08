﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class DeckOfCards
    {
        public void Initialize() {
            string[] cards = new string[52] { 
                "C-2", "C-3", "C-4", "C-5", "C-6", "C-7", "C-8", "C-9", "C-10", "C-Jack", "C-Queen", "C-King", "C-Ace", 
                "D-2", "D-3", "D-4", "D-5", "D-6", "D-7", "D-8", "D-9", "D-10", "D-Jack", "D-Queen", "D-King", "D-Ace", 
                "H-2", "H-3", "H-4", "H-5", "H-6", "H-7", "H-8", "H-9", "H-10", "H-Jack", "H-Queen", "H-King", "H-Ace", 
                "S-2", "S-3", "S-4", "S-5", "S-6", "S-7", "S-8", "S-9", "S-10", "S-Jack", "S-Queen", "S-King", "S-Ace" };

            Randomize(cards);

            bool[] avail = new bool[52];
            /*Console.WriteLine("After Shuffling:");
            for (int i = 0; i < cards.Length; i++)
                Console.Write(cards[i] + " ");*/

            int k = 0;
            string[,] player = new string[4, 9];
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 9; j++) {
                    player[i, j]= cards[k++];
                }
            }

            k = 0;
            for (int i = 0; i < 4; i++) {
                Console.Write("Player {0}: ", (i + 1));
                for (int j = 0; j < 9; j++) {
                    Console.Write(cards[k++]+" ");
                }
                Console.WriteLine();
            }
        }

        public string[] Randomize(string[] cards) {
            Random random = new Random();
            for (int i = 0; i < cards.Length - 1; i++) {
                int j = random.Next(i, cards.Length);
                string temp;
                temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
            return cards;
        }
    }
}
