using System.Collections.Generic;
using D3MarketPlace.ObjectModel;

namespace D3MarketPlace
{
    public class ProductBuilder
    {
git         public ICollection<Product> GetAllProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Natalya's Sight",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Helm
                },
                new Product
                {
                    Name = "Mantle of Channeling",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Shoulders
                },
                new Product
                {
                    Name = "Natalya's Touch",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Gloves
                },
                new Product
                {
                    Name = "Natalya's Embrace",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Chest
                },
                new Product
                {
                    Name = "Hellcat Waistguard",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Belt
                },                
                new Product
                {
                    Name = "Natalya's Leggings",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Leggings
                },
                new Product
                {
                    Name = "Natalya's Bloody Footprints",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Boots
                },
                new Product
                {
                    Name = "Wraps of Clarity",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Arms
                },
                new Product
                {
                    Name = "Hellfire Amulet of Dexterity",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Amulet
                },
                new Product
                {
                    Name = "Natalya's Slayer Natalya",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Weapon
                },
                new Product
                {
                    Name = "Focus",
                    Rarity = Rarity.Set,
                    Set= "Bastions of Will",
                    Type = ProductType.Ring
                },
                
                new Product
                {
                    Name = "Restraint",
                    Rarity = Rarity.Set,
                    Set= "Bastions of Will",
                    Type = ProductType.Ring
                },
                new Product
                {
                    Name = "Dawn",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Weapon
                },
                new Product
                {
                    Name = "Lord Greenstone's Fan",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Weapon
                },
                new Product
                {
                    Name = "Aquila Cuirass",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Chest
                },
                new Product
                {
                    Name = "Convention of Elements",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Ring
                },
                new Product
                {
                    Name = "The Witching Hour",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Belt
                },
                new Product
                {
                    Name = "Andariel's Visage",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Helm
                },
            };
            return products;
        }

        private ICollection<Product> BuildProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Name = "Natalya's Sight",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Helm
                },
                new Product
                {
                    Name = "Mantle of Channeling",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Shoulders
                },
                new Product
                {
                    Name = "Natalya's Touch",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Gloves
                },
                new Product
                {
                    Name = "Natalya's Embrace",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Chest
                },
                new Product
                {
                    Name = "Hellcat Waistguard",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Belt
                },                
                new Product
                {
                    Name = "Natalya's Leggings",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Leggings
                },
                new Product
                {
                    Name = "Natalya's Bloody Footprints",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Boots
                },
                new Product
                {
                    Name = "Wraps of Clarity",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Arms
                },
                new Product
                {
                    Name = "Hellfire Amulet of Dexterity",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Amulet
                },
                new Product
                {
                    Name = "Natalya's Slayer Natalya",
                    Rarity = Rarity.Set,
                    Set = "Natalya",
                    Type = ProductType.Weapon
                },
                new Product
                {
                    Name = "Focus",
                    Rarity = Rarity.Set,
                    Set= "Bastions of Will",
                    Type = ProductType.Ring
                },
                
                new Product
                {
                    Name = "Restraint",
                    Rarity = Rarity.Set,
                    Set= "Bastions of Will",
                    Type = ProductType.Ring
                },
                new Product
                {
                    Name = "Dawn",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Weapon
                },
                new Product
                {
                    Name = "Lord Greenstone's Fan",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Weapon
                },
                new Product
                {
                    Name = "Aquila Cuirass",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Chest
                },
                new Product
                {
                    Name = "Convention of Elements",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Ring
                },
                new Product
                {
                    Name = "The Witching Hour",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Belt
                },
                new Product
                {
                    Name = "Andariel's Visage",
                    Rarity = Rarity.Legendary,
                    Type = ProductType.Helm
                },
            };
            return products;
        }
    }
}