using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinalCSharpQuark.Model
{
    public enum DressQuality
    {
        Standar,
        Premium
    }

    public abstract class Dress
    {
        DressQuality quality;
        double unitPrice;
        uint stockAmount;

        public Dress(DressQuality Quality, double UnitPrice, uint StockAmount)
        {
            if (UnitPrice == 0)
                throw new ArgumentException("This value can´t be 0");

            quality = Quality;
            unitPrice = UnitPrice;
            stockAmount = StockAmount;
        }

        public double UnitPrice { get => unitPrice;}
        public uint StockAmount { get => stockAmount; set => stockAmount = value;}
        public DressQuality Quality { get => quality;}
    }
}
