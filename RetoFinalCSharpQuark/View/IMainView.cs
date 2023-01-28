using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinalCSharpQuark.View
{
    public interface IMainView
    {
        string shopName { set; }
        string shopAddress { set; }
        string sellerName {set; }
        string sellerId {set; }
        bool isShirt { get;}
        bool isShort { get;}
        bool MaoNeck { get; }
        bool isSlim { get;}
        bool isPremium { get;}
        string selectedDressStock { get; set; }
        string unitPrice { get; }
        string dressAmount { get; }
        string quotedTotalValue {set; }


        event Action UpdatedDressData;
        event Action MakeQuote;
        event Action QuotesHistory;

        bool CompleteDressDefinition();

        void Show();

        void ShowError(string Message);

    }
}
