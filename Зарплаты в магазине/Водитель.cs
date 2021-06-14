using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплаты_в_магазине
{
    class Vodila : Vodila1
    {
       
        private double _Textt;

        public double Formula3()
        {
            return _Textt * 0.85;
        }

        public void III2(double Textt)
        {
            _Textt = Textt;
        }

      
    }
}
