using System;

namespace Design_Pattern
{
    public class ShoppingCartVisitorImplementation : ShoppingCartVisitor
    {
        public ShoppingCartVisitorImplementation()
        { 
        }

        public int visit(Book book)
        {
            int cost = 0;
            if (book.getPrice() > 50)
            {
                cost = book.getPrice() - 5;
            }
            else
            {
                cost = book.getPrice();
            }

            Console.WriteLine("Book ISBN:: " + book.getIsbnNumber() + " Cost = " + cost);
            return cost;
        }

        public int visit(Fruit fruit)
        {
            int cost = fruit.getPricePerKg() * fruit.getWeight();
            Console.WriteLine(fruit.getName() + " Cost = " + cost);
            return cost;
        }
    }
}