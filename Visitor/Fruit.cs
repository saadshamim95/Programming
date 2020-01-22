namespace Design_Pattern
{
    public class Fruit : ItemElement
    {
        private int pricePerkg;
        private int weight;
        private string name;

        public Fruit(int perKg, int weight, string name)
        {
            this.pricePerkg = perKg;
            this.weight = weight;
            this.name = name;
        }

        public int getPricePerKg()
        {
            return this.pricePerkg;
        }

        public int getWeight()
        {
            return this.weight;
        }

        public string getName()
        {
            return this.name;
        }

        public int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.visit(this);
        }
    }
}
