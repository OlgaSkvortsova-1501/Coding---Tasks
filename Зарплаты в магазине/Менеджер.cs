using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Зарплаты_в_магазине
{
   
    class Menedjer : Menedjer1
    {
        private double _Text;
        private double _Textt;

        public double Formula2()
        {
            return  (Math.Pow(_Textt, 2)) * 0.25 * (Math.Pow(10,-3)) + _Text * 0.5 * (Math.Pow(10, (-2)));
        }

        public void OOO2(double Textt)
        {
            _Textt = Textt;
        }

        public void OOO1(double Text)
        {
            _Text = Text;

        }


    }
}
