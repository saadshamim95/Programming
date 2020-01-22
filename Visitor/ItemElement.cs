namespace Design_Pattern
{
    public interface ItemElement
    {
        public int Accept(ShoppingCartVisitor visitor);
    }
}
