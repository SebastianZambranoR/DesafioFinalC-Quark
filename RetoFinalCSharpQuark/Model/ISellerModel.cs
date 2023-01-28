using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinalCSharpQuark.Model
{
    public interface ISellerModel
    {
        string GetSellerName();
        string GetSellerId();
        string GetShopName();
        string GetShopAddres();

        List<Quote> GetSellerHistory();

        double MakeQuote(Dress Dress, uint Amount);

        uint GetStockAmount(bool IsShort, bool MaoNeck);

        uint GetStockAmount(bool IsSlim);
    }
}
