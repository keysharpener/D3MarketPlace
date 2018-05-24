# D3MarketPlace Kata

## Design and implement a program allowing its users to add, delete and update transactions in an SQL database.

### Technical pre-requisites
* [Git](https://git-scm.com/downloads)
* [Visual Studio](https://www.visualstudio.com/downloads/)
* [PostgreSQL](https://www.postgresql.org/download/)


### Background
In the world of Diablo 3, characters often transact with the local merchants. They may indeed need new gear, new items, potions etc. Your goal is to generate a backlog of transactions, and allow your users to add new ones, update old ones, or delete obsolete ones. It should also allow the user to access additional information, like a character's inventory.

### Designing relational data model
The first step in designing this solution is to come up with a database model. For this kata, we will use Postgresql, a standard of the free, open source relational databases solutions. 

The data model in the code will be the following : 
```csharp
    public class Transaction
    {
        public int Id { get; internal set; }
        public string Trader { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public int Version { get; set; }
        public string Counterparty { get; set; }
        public Currency Currency { get; set; }
        public DateTime TradeDate { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public Product Product{ get; set; }
    }

    public class Product
    {
        public string Name { get; set; }
        public Rarity Rarity { get; set; }
        public string Set { get; set; }
        public ProductType Type { get; set; }
    }

    public class Counterparty
    {
        public string Name { get; set; }
        public Currency Currency { get; set; }
    }

    public class Trader
    {
        public CharacterClass Class { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        public int Level {get;set;}
    }

    public enum Currency
    {
        BloodShards,Gold
    }

    public enum CharacterClass
    {
        Barbarian, WitchDoctor, Wizard, Monk, DemonHunter, Crusader, Necromancer
    }

    public enum ProductType
    {
        Helm,Chest,Belt,Leggings,Boots,Weapon,Shield,Shoulders,Gloves,Arms,Amulet,Ring
    }

    public enum Rarity
    {
        Normal,
        Magic,
        Rare,
        Legendary,
        Set
    }
```

Your goal is to come up with a relational model for this design. Besides row ids, ***no data should be replicated*** between tables.

Below is an example of the kind of schema that is expected:
![](http://s3.amazonaws.com/dev.assets.neo4j.com/wp-content/uploads/20160229120043/organization-relational-model.png)


If you don't know where to start, please refer to the following : 
* [Relational databases](https://en.wikipedia.org/wiki/Relational_database)
* [Primary and foreign keys](https://www.postgresql.org/docs/9.2/static/ddl-constraints.html)
* [Create table](https://www.postgresql.org/docs/9.1/static/sql-createtable.html)
* [Column types](https://www.postgresql.org/docs/9.2/static/datatype.html)
* [Insert data](https://www.postgresql.org/docs/8.1/static/sql-insert.html)


Once your data model is set up, query it in SQL. Try to get the following information:
* How much items in the database are legendary? 
* What is the maximum level of the Barbarian characters? 
