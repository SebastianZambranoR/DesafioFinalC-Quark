using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetoFinalCSharpQuark.Model;
using RetoFinalCSharpQuark.View;
using RetoFinalCSharpQuark.Presenter;
using System.Data;

namespace RetoFinalCSharpQuark.Presenter
{
    class QuoteHistoryPresenter
    {
        IHistoryView view;
        ISellerModel seller;

        public QuoteHistoryPresenter(IHistoryView View, ISellerModel Seller)
        {
            view = View;
            seller = Seller;

            DataTable quoteList = new DataTable();
            quoteList.Columns.Add("ID", typeof(string));
            quoteList.Columns.Add("Fecha", typeof(DateTime));
            quoteList.Columns.Add("Codigo vendedor", typeof(string));
            quoteList.Columns.Add("Prenda cotizada", typeof(string));
            quoteList.Columns.Add("Cantidad cotizada", typeof(uint));
            quoteList.Columns.Add("Valor total", typeof(double));

            List<Quote> quotes = seller.GetSellerHistory();

            for (int i = 0; i < quotes.Count; i++)
            {
                quoteList.Rows.Add(new object[] { quotes[i].Id, quotes[i].Date, quotes[i].SellerId, GetStringDressType(quotes[i].QuotedDress), quotes[i].QuotedAmount, quotes[i].QuotedValue });
            }


            view.QuoteTable = quoteList;

            view.SetDataSource();

            view.Show();
        }


        private string GetStringDressType(Dress dress)
        {
            string dressText = "";

            string type = "";
            string complement = "";
            string complement2 = "";
            string quality = "";

            if (dress.GetType() == typeof(Shirt))
            {
                Shirt shirt = (Shirt)dress;
                type = "Camiseta";
                if(shirt.ShirtSleeve == ShirtSleeve.Long)
                {
                    complement = "Manga larga";
                    if (shirt.ShirtNeck == ShirtNeck.Common)
                    {
                        complement2 = "";
                    }
                    else
                    {
                        complement2 = "Cuello Mao";
                    }

                }
                else
                {
                    complement = "Manga corta";

                    if (shirt.ShirtNeck == ShirtNeck.Common)
                    {
                        complement2 = "";
                    }
                    else
                    {
                        complement2 = "Cuello Mao";
                    }
                }
            }
            else
            {

                Jean jean = (Jean)dress;
                type = "Pantalon";

                if(jean.JeanType == JeanType.Slim)
                {
                    complement = "Chupin";
                }
            }

            if(dress.Quality == DressQuality.Premium)
            {
                quality = "Premium";
            }
            else
            {
                quality = "Standar";
            }


            dressText = complement2 != "" ? type + " " + complement + " " + complement2 + " " + quality : type + " " + complement + " " + quality;

            return dressText;
        }
    }
}
