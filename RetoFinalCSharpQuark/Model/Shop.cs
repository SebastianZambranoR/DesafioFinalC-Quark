using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinalCSharpQuark.Model
{
    class Shop
    {
        private string shopName;
        private string shopAddress;
        private List<Seller> sellers;
        private List<Dress> products;

        public Shop(string ShopName, string ShopAddress, List<Seller> Sellers, List<Dress> Products)
        {
            shopName = ShopName;
            shopAddress = ShopAddress;
            sellers = Sellers;
            products = Products;
        }

        public string ShopName { get => shopName;}
        public string ShopAddress { get => shopAddress;}
        public List<Dress> Products { get => products;}
        public List<Seller> Sellers { get => sellers;}
    }
}
