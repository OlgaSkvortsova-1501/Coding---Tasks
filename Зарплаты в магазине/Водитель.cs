using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплаты_в_магазине
{
    class Vodila : ALL
    {

        private double _BaseZP;
        private double _MonProfit;
       

        public double Formula3()
        {
            return _BaseZP * 0.85;
        }

        public void Profit(double MonProfit)
        {
            _MonProfit = MonProfit;

        }

        public void ZP(double BaseZP)
        {
            _BaseZP = BaseZP;
        }

      
    }
}
