using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплаты_в_магазине
{
   
    class Menedjer : ALL
    {
        private double _MonProfit;
        private double _BaseZP;

        public double Formula2()
        {
            return  (Math.Pow(_BaseZP, 2)) * 0.25 * (Math.Pow(10,-3)) + _MonProfit * 0.5 * (Math.Pow(10, (-2)));
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
