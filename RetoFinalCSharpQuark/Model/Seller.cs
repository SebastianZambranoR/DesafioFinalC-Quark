using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinalCSharpQuark.Model
{
    class Seller
    {
        private string name;
        private string lastName;
        private string sellerId;
        private Shop shop;

        private List<Quote> quotesHistory;


        public Seller(string Name, string LastName,Shop Shop, string SellerId)
        {
            if (String.IsNullOrEmpty(Name) || String.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("Invalid Name");
            if(String.IsNullOrEmpty(LastName) || String.IsNullOrWhiteSpace(LastName))
                throw new ArgumentException("Invalid Last name");
            if (String.IsNullOrEmpty(SellerId) || String.IsNullOrWhiteSpace(SellerId))
                throw new ArgumentException("Invalid Seller id");

            name = Name;
            lastName = LastName;
            sellerId = SellerId;
            shop = Shop;
            quotesHistory = new List<Quote>();
        }

        public Seller(string Name, string LastName,Shop Shop,string SellerId, List<Quote> QuotesHistory)
        {
            if (String.IsNullOrEmpty(Name) || String.IsNullOrWhiteSpace(Name))
                throw new ArgumentException("Invalid Name");
            if (String.IsNullOrEmpty(LastName) || String.IsNullOrWhiteSpace(LastName))
                throw new ArgumentException("Invalid Last name");
            if (String.IsNullOrEmpty(SellerId) || String.IsNullOrWhiteSpace(SellerId))
                throw new ArgumentException("Invalid Seller id");

            name = Name;
            lastName = LastName;
            sellerId = SellerId;
            shop = Shop;
            quotesHistory = QuotesHistory;
        }

        public string Name { get => name;}
        public string LastName { get => lastName;}
        public string SellerId { get => sellerId; }
        public List<Quote> QuotesHistory { get => quotesHistory;}
        public Shop Shop { get => shop; set => shop = value; }

        public double MakeQuote(Dress Dress, uint Amount)
        {
            int generatedId = quotesHistory.Count;

            Quote quote = new Quote(generatedId.ToString(), sellerId, Dress, Amount);

            quotesHistory.Add(quote);

            return quote.QuotedValue;
        }
    }
}
