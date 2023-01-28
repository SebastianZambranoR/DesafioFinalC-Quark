using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoFinalCSharpQuark.Model
{
    public enum JeanType
    {
        Common,
        Slim
    }

    public class Jean : Dress
    {
        private JeanType jeanType;
        public Jean(JeanType JeanType,DressQuality Quality, double UnitPrice, uint StockAmount) : base(Quality, UnitPrice, StockAmount)
        {
            jeanType = JeanType;
        }

        public JeanType JeanType { get => jeanType;}
    }
}
