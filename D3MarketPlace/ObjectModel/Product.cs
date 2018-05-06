namespace D3MarketPlace.ObjectModel
{
    public class Product
    {
        public string Name { get; set; }
        public Rarity Rarity { get; set; }
        public string Set { get; set; }
        public ProductType Type { get; set; }
    }
}