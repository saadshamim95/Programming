namespace Design_Pattern
{
    public class Book : ItemElement
    {
        private int price;
        private string isbnNumber;

        public Book(int cost, string isbn)
        {
            this.price = cost;
            this.isbnNumber = isbn;
        }

        public int getPrice()
        {
            return this.price;
        }

        public string getIsbnNumber()
        {
            return this.isbnNumber;
        }

        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}