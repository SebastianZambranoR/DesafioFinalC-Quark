using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RetoFinalCSharpQuark.Model;
using RetoFinalCSharpQuark.View;

namespace RetoFinalCSharpQuark.Presenter
{
    class MainPresenter
    {
        IMainView view;
        ISellerModel sellerModel;

        public MainPresenter(IMainView View, ISellerModel SellerModel)
        {
            view = View;
            sellerModel = SellerModel;


            view.UpdatedDressData += CheckStock;
            view.MakeQuote += CreateQuote;
            view.QuotesHistory += ShowQuoteHistory;

            //InitValues
            view.sellerName = sellerModel.GetSellerName();
            view.sellerId = sellerModel.GetSellerId();
            view.shopName = SellerModel.GetShopName();
            view.shopAddress = SellerModel.GetShopAddres();

            view.Show();
        }

        private void ShowQuoteHistory()
        {
            IHistoryView historyView = new QuotesHistory();
            QuoteHistoryPresenter histoyPresenter = new QuoteHistoryPresenter(historyView, sellerModel);
        }

        private void CreateQuote()
        {
            bool fieldsDefined = view.CompleteDressDefinition();

            if (!fieldsDefined)
            {
                view.ShowError("Verifica los valores para poder realizar la cotizacion");
                return;
            }

            if(String.IsNullOrWhiteSpace(view.unitPrice))
            {
                view.ShowError("Debes ingresar un valor para continuar");
                return;
            }

            if (String.IsNullOrWhiteSpace(view.dressAmount))
            {
                view.ShowError("Debes ingresar una cantidad para continuar");
                return;
            }

            uint ingresedPrice = uint.Parse(view.unitPrice);
            uint quotedAmount = uint.Parse(view.dressAmount);

            bool correctPrice = ingresedPrice > 0;

            bool correctAmount = quotedAmount > 0;



            if (!correctPrice)
            {
                view.ShowError("El precio no puede ser 0");
                return;
            }

            if (!correctAmount)
            {
                view.ShowError("La cantidad no puede ser 0");
                return;
            }

            if(quotedAmount > int.Parse(view.selectedDressStock))
            {
                view.ShowError("La cantidad no puede ser mayor al stock");
                return;
            }

            bool isShirt = view.isShirt;
            bool isPremium = view.isPremium;

            Dress quotedDress;
            if (isShirt)
            {
                bool isShort = view.isShort;
                bool maoNeck = view.MaoNeck;


                if (isShort)
                {
                    if (maoNeck)
                    {
                        if (isPremium)
                        {
                            quotedDress = new Shirt(ShirtSleeve.Short, ShirtNeck.Mao, DressQuality.Premium, ingresedPrice, quotedAmount);

                        }
                        else
                        {
                            quotedDress = new Shirt(ShirtSleeve.Short, ShirtNeck.Mao, DressQuality.Standar, ingresedPrice, quotedAmount);

                        }
                    }
                    else
                    {
                        if (isPremium)
                        {
                            quotedDress = new Shirt(ShirtSleeve.Short, ShirtNeck.Common, DressQuality.Premium, ingresedPrice, quotedAmount);
                        }
                        else
                        {
                            quotedDress = new Shirt(ShirtSleeve.Short, ShirtNeck.Common, DressQuality.Standar, ingresedPrice, quotedAmount);
                        }
                    }
                }
                else
                {
                    if (maoNeck)
                    {
                        if (isPremium)
                        {
                            quotedDress = new Shirt(ShirtSleeve.Long, ShirtNeck.Mao, DressQuality.Premium, ingresedPrice, quotedAmount);
                        }
                        else
                        {
                            quotedDress = new Shirt(ShirtSleeve.Long, ShirtNeck.Mao, DressQuality.Standar, ingresedPrice, quotedAmount);
                        }
                    }
                    else
                    {
                        if (isPremium)
                        {
                            quotedDress = new Shirt(ShirtSleeve.Long, ShirtNeck.Common, DressQuality.Premium, ingresedPrice, quotedAmount);
                        }
                        else
                        {
                            quotedDress = new Shirt(ShirtSleeve.Long, ShirtNeck.Common, DressQuality.Standar, ingresedPrice, quotedAmount);
                        }
                    }
                }
                    
                }
            else
            {
                bool isSlim = view.isSlim;
                if (isSlim)
                {
                    if (isPremium)
                    {
                        quotedDress = new Jean(JeanType.Slim, DressQuality.Premium, ingresedPrice, quotedAmount);
                    }
                    else
                    {
                        quotedDress = new Jean(JeanType.Slim, DressQuality.Standar, ingresedPrice, quotedAmount);
                    }
                }
                else
                {
                    if (isPremium)
                    {
                        quotedDress = new Jean(JeanType.Common, DressQuality.Premium, ingresedPrice, quotedAmount);
                    }
                    else
                    {
                        quotedDress = new Jean(JeanType.Common, DressQuality.Standar, ingresedPrice, quotedAmount);
                    }
                }
            }

            double totalValue= sellerModel.MakeQuote(quotedDress, quotedAmount);

            view.quotedTotalValue = totalValue.ToString();
            
        }

        private void CheckStock()
        {
            bool canCheck = view.CompleteDressDefinition();
            uint stock = 0;
            if (canCheck)
            {

                bool isShirt = view.isShirt;
                if (isShirt)
                {
                    bool isShort = view.isShort;
                    bool maoNeck = view.MaoNeck;

                    stock = sellerModel.GetStockAmount(isShort, maoNeck);
                }
                else
                {
                    bool isSlim = view.isSlim;

                    stock = sellerModel.GetStockAmount(isSlim);
                }

                view.selectedDressStock = stock.ToString();


            }

        }
    }
}
