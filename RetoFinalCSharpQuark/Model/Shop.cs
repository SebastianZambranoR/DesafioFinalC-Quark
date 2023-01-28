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

        public Shop(string ShopName, string ShopAddress)
        {
            shopName = ShopName;
            shopAddress = ShopAddress;
            sellers = new List<Seller>();
            products = Products;
            products = new List<Dress>();
            InitializeData();
        }

        public string ShopName { get => shopName;}
        public string ShopAddress { get => shopAddress;}
        public List<Dress> Products { get => products;}
        public List<Seller> Sellers { get => sellers;}

        public void InitializeData()
        {
            Shirt ShortSleeveCommonPremium = new Shirt(ShirtSleeve.Short, ShirtNeck.Common, DressQuality.Premium, 1, 150);
            Shirt ShortSleeveCommonStandar = new Shirt(ShirtSleeve.Short, ShirtNeck.Common, DressQuality.Standar, 1, 150);

            Shirt ShortSleeveMaoPremium = new Shirt(ShirtSleeve.Short, ShirtNeck.Mao, DressQuality.Premium, 1, 100);
            Shirt ShortSleeveMaoStandar = new Shirt(ShirtSleeve.Short, ShirtNeck.Mao, DressQuality.Standar, 1, 100);

            Shirt LongSleeveCommonPremium = new Shirt(ShirtSleeve.Long, ShirtNeck.Common, DressQuality.Premium, 1, 175);
            Shirt LongSleeveCommonStandar = new Shirt(ShirtSleeve.Long, ShirtNeck.Common, DressQuality.Standar, 1, 175);

            Shirt LongSleeveMaoPremium = new Shirt(ShirtSleeve.Long, ShirtNeck.Mao, DressQuality.Premium, 1, 75);
            Shirt LongSleeveMaoStandar = new Shirt(ShirtSleeve.Long, ShirtNeck.Mao, DressQuality.Standar, 1, 75);

            Jean CommonPremium = new Jean(JeanType.Common, DressQuality.Premium, 1, 250);
            Jean CommonStandar = new Jean(JeanType.Common, DressQuality.Standar, 1, 250);

            Jean SlimPremium = new Jean(JeanType.Slim, DressQuality.Premium, 1, 750);
            Jean SlimStandar = new Jean(JeanType.Slim, DressQuality.Standar, 1, 750);

            Products.Add(ShortSleeveCommonPremium);
            Products.Add(ShortSleeveCommonStandar);

            Products.Add(ShortSleeveMaoPremium);
            Products.Add(ShortSleeveMaoStandar);

            Products.Add(LongSleeveCommonPremium);
            Products.Add(LongSleeveCommonStandar);

            Products.Add(LongSleeveMaoPremium);
            Products.Add(LongSleeveMaoStandar);

            Products.Add(CommonPremium);
            Products.Add(CommonStandar);

            Products.Add(SlimPremium);
            Products.Add(SlimStandar);

        }

        public void AddSeller(Seller seller)
        {
            sellers.Add(seller);
        }

        public uint GetProductStock(bool IsShort, bool MaoNeck)
        {

            for (int i = 0; i < Products.Count; i++)
            {
                if(Products[i].GetType() == typeof(Shirt))
                {
                    Shirt shirt = (Shirt)Products[i];
                    ShirtSleeve sleeve = IsShort ? ShirtSleeve.Short : ShirtSleeve.Long;
                    ShirtNeck neck = MaoNeck ? ShirtNeck.Mao : ShirtNeck.Common;

                    if(shirt.ShirtSleeve == sleeve && shirt.ShirtNeck == neck)
                    {
                        return shirt.StockAmount;
                    }
                }
            }

            return 0;
        }

        public uint GetProductStock(bool IsSlim)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].GetType() == typeof(Jean))
                {
                    Jean jean = (Jean)Products[i];
                    JeanType type = IsSlim ? JeanType.Slim : JeanType.Common;

                    if (jean.JeanType == type)
                    {
                        return jean.StockAmount;
                    }
                }
            }

            return 0;
        }
    }
}
