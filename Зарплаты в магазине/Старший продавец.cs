using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплаты_в_магазине
{
    class StProdaves : ALL
    {
        private double _MonProfit;
        private double _BaseZP;

        public double Formula1()
        {
          
            return (Math.Pow(_BaseZP, 2)) * 0.15 * (Math.Pow(10,-3)) + _MonProfit * 0.1 * (Math.Pow(10, (-2)));
        }

        public void ZP(double BaseZP)
        {
            _BaseZP = BaseZP;
        }

        public void Profit(double MonProfit)
        {
            _MonProfit = MonProfit;

        }

       
    }
}
