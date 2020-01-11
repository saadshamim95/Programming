using System;

namespace Object_Oriented
{
    class Program
    {
        static void Main(string[] args)
        {
            /*InventoryManager manager = new InventoryManager();
            manager.Test();

            StockPortfolio portfolio = new StockPortfolio();
            portfolio.Test();*/

            DeckOfCards deck = new DeckOfCards();
            deck.Initialize();
        }
    }
}