using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinalCSharpQuark.Model
{
    class Quote
    {
        string id;
        DateTime date;
        string sellerId;
        Dress quotedDress;
        uint quotedAmount;
        double quotedValue;

        public Quote(string Id, string SellerId, Dress QuotedDress, uint QuotedAmount)
        {
            id = Id;
            date = DateTime.Now.Date;
            sellerId = SellerId;
            quotedDress = QuotedDress;
            quotedAmount = QuotedAmount;

            quotedValue = CalculateQuoteValue();

        }

        private double CalculateQuoteValue()
        {
            double finalValue = quotedDress.UnitPrice;

            if(quotedDress.GetType() == typeof(Jean))
            {
                Jean temp = (Jean)quotedDress;
                if (temp.JeanType == JeanType.Slim)
                    finalValue -= (finalValue * 12) / 100;
            }
            else
            {
                Shirt temp = (Shirt)quotedDress;
                if (temp.ShirtSleeve == ShirtSleeve.Short)
                    finalValue -= (finalValue * 10) / 100;
                if (temp.ShirtNeck == ShirtNeck.Mao)
                    finalValue += (finalValue * 3) / 100;
            }

            if (quotedDress.Quality == DressQuality.Premium)
                finalValue += (finalValue * 30) / 100;

            finalValue *= quotedAmount;

            return finalValue;
        }

        public string Id { get => id; }
        public DateTime Date { get => date;}
        public string SellerId { get => sellerId; }
        public uint QuotedAmount { get => quotedAmount;}
        public double QuotedValue { get => quotedValue;}
        public Dress QuotedDress { get => quotedDress;}
    }
}
