using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Timers;
using D3MarketPlace.ObjectModel;

namespace D3MarketPlace
{
    public class TransactionService
    {
        public delegate void MyEventHandler(Transaction newTrade);
        public event MyEventHandler OnNewTransaction;
        private Timer _timer;
        private readonly ICollection<Transaction> _transactions = new Collection<Transaction>();
        private readonly ICollection<Product> _products;
        private readonly ICollection<string> _traders = new Collection<string>
        {
            "Barbarian",
            "Witch Doctor",
            "Wizard",
            "Monk",
            "Demon Hunter",
            "Crusader",
            "Necromancer"
        };

        private readonly ICollection<string> _counterparties = new Collection<string>()
        {
            "Kadala",
            "Blacksmith",
            "Jeweller",
            "Enchantress",
        };

        public TransactionService(bool realTime, int numberOfDeals)
        {
            _products = ProductBuilder.GetAllProducts();
            if (realTime)
            {
                ConfigureTimer();                
            }
            for (var i = 0; i < numberOfDeals; i++)
            {
                AddTrade();
            }
        }

        public ICollection<Transaction> GetAllTrades()
        {
            return _transactions;
        }

        public ICollection<Transaction> GetRandomTrades(int numberOfDeals)
        {
            var result = new Collection<Transaction>();
            for (var i = 0; i < numberOfDeals; i++)
            {
                result.Add(GetTrade());
            }
            return result;
        }
        
        private void ConfigureTimer()
        {
            _timer = new Timer {Interval = 1000};
            _timer.Elapsed +=  TimerOnElapsed;
            _timer.Start();
        }

        private void TimerOnElapsed(object sender, ElapsedEventArgs elapsedEventArgs)
        {
            AddTrade();
        }

        
        private void AddTrade()
        {
            var trade = GetTrade();
            _transactions.Add(trade);
            NotifyDealListeners(trade);
        }

        private Transaction GetTrade()
        {
            var random = new Random(GetSeed());
            var transaction = new Transaction
            {
                Trader = GetRandomElementFromList(_traders),
                Counterparty = GetRandomElementFromList(_counterparties),
                LastUpdateTime = DateTime.Now,
                TradeDate = DateTime.Today,
                Id = _transactions.Count + 1,
                Product = GetRandomElementFromList(_products),
                Quantity = random.Next(1, 10),
                UnitPrice = random.NextDouble() * 100
            };
            transaction.Version = _transactions.Count(t => t.Id == transaction.Id);
            transaction.Currency = transaction.Counterparty == "Kadala" ? Currency.BloodShards : Currency.Gold;
            return transaction;
        }

        
        private T GetRandomElementFromList<T>(ICollection<T> list)
        {
            var random = new Random(GetSeed());
            var randomPosition = random.Next(0, list.Count - 1);
            return list.ElementAt(randomPosition);
        }

        private int GetSeed()
        {
            using (RNGCryptoServiceProvider rg = new RNGCryptoServiceProvider()) 
            { 
                byte[] rno = new byte[5];    
                rg.GetBytes(rno);    
                return BitConverter.ToInt32(rno, 0); 
            }
        }

        protected void NotifyDealListeners(Transaction foo)
        {
            OnNewTransaction?.Invoke(foo);
        }
    }
}