using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinalCSharpQuark.Model
{
    public enum ShirtSleeve
    {
        Long,
        Short
    }

    public enum ShirtNeck
    {
        Common,
        Mao
    }

    public class Shirt : Dress
    {
        private ShirtSleeve shirtSleeve;
        private ShirtNeck shirtNeck;
        public Shirt(ShirtSleeve ShirtSleeve, ShirtNeck ShirtNeck,DressQuality Quality, double UnitPrice, uint StockAmount) : base(Quality, UnitPrice, StockAmount)
        {
            shirtSleeve = ShirtSleeve;
            shirtNeck = ShirtNeck;
        }

        public ShirtSleeve ShirtSleeve { get => shirtSleeve;}
        public ShirtNeck ShirtNeck { get => shirtNeck;}
    }
}
