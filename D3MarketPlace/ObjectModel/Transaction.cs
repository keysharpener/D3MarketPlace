using System;

namespace D3MarketPlace.ObjectModel
{
    public class Transaction
    {
        public int Id { get; set; }
        public string Trader { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int Version { get; set; }
        public string Counterparty { get; set; }
        public Currency Currency { get; set; }
        public DateTime TradeDate { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public Product Product{ get; set; }

        public override string ToString()
        {
            return $"{Trader} bought {Quantity} {Product.Name} from {Counterparty} at {UnitPrice} {Currency} each";
        }
    }
}