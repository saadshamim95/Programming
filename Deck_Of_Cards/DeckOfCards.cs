using System;

namespace Object_Oriented
{
    class DeckOfCards
    {
        /// <summary>
        /// Initializing the Cards
        /// </summary>
        public void Initialize() {
            /*string[] cards = new string[52] { 
                "C-2", "C-3", "C-4", "C-5", "C-6", "C-7", "C-8", "C-9", "C-10", "C-Jack", "C-Queen", "C-King", "C-Ace", 
                "D-2", "D-3", "D-4", "D-5", "D-6", "D-7", "D-8", "D-9", "D-10", "D-Jack", "D-Queen", "D-King", "D-Ace", 
                "H-2", "H-3", "H-4", "H-5", "H-6", "H-7", "H-8", "H-9", "H-10", "H-Jack", "H-Queen", "H-King", "H-Ace", 
                "S-2", "S-3", "S-4", "S-5", "S-6", "S-7", "S-8", "S-9", "S-10", "S-Jack", "S-Queen", "S-King", "S-Ace" };*/

            string[] cards = new string[36] {
                "C-2", "C-3", "C-4", "C-5", "C-6", "C-7", "C-8", "C-9", "C-10",
                "D-2", "D-3", "D-4", "D-5", "D-6", "D-7", "D-8", "D-9", "D-10",
                "H-2", "H-3", "H-4", "H-5", "H-6", "H-7", "H-8", "H-9", "H-10",
                "S-2", "S-3", "S-4", "S-5", "S-6", "S-7", "S-8", "S-9", "S-10", };

            Randomize(cards);

            int k = 0;
            string[,] players = new string[4, 9];
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 9; j++) {
                    players[i, j]= cards[k++];
                }
            }

            string[] player = new string[9];
            for (int i = 0; i < 9; i++)
                player[i] = cards[i];

            Player player1 = new Player();
            player1.Sort(player);
            /*QueueUsingLinkedList<string>[] queue = new QueueUsingLinkedList<string>[4];
            for (int i = 0; i < 4; i++)
                queue[i] = new QueueUsingLinkedList<string>();

            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 9; j++) {
                    queue[i].enqueue(players[i, j]);
                }
            }

            Console.WriteLine("Printing from Linked List:");
            for (int i = 0; i < 4; i++) {
                Console.Write("Player {0}: ", i);
                queue[i].Print();
                Console.WriteLine();
            }*/
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