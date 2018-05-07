using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using D3MarketPlace;
using D3MarketPlace.ObjectModel;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var transactionService = new TransactionService(true, 10);
            var allTrades = transactionService.GetAllTrades();
            allTrades.ToList().ForEach(Console.WriteLine);
            transactionService.OnNewTransaction += TransactionServiceOnOnNewTransaction;
            Console.ReadKey();
        }

        private static void TransactionServiceOnOnNewTransaction(Transaction newTrade)
        {
            Console.WriteLine(newTrade);
        }
    }
}