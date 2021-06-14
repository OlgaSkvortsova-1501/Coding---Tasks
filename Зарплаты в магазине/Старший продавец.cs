using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплаты_в_магазине
{
    class StProdaves : StProdaves1
    {
        private double _Text;
        private double _Textt;

        public double Formula1()
        {
          
            return (Math.Pow(_Textt, 2)) * 0.15 * (Math.Pow(10,-3)) + _Text * 0.1 * (Math.Pow(10, (-2)));
        }

        public void PPP2(double Textt)
        {
            _Textt = Textt;
        }

        public void PPP1(double Text)
        {
            _Text = Text;

        }
    
    }
}
