using System;

namespace Design_Pattern
{
    class ShoppingCartClient
    {
        public void Test()
        {
            ItemElement[] items = new ItemElement[] { new Book(20, "ABC1234"), new Book(100, "DEF5678"),
                new Fruit(10, 2, "Banana"), new Fruit(5, 5, "Apple") };
            int total = calculatePrice(items);
            Console.WriteLine("Total Price: " + total);
        }

        public int calculatePrice(ItemElement[] items)
        {
            ShoppingCartVisitor cart = new ShoppingCartVisitorImplementation();
            int sum = 0;
            foreach (ItemElement item in items)
            {
                sum = sum + item.Accept(cart);
            }

            return sum;
        }
    }
}