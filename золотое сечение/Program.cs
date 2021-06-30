using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace золотое_сечение
{
    class Program
    {
        static void Main(string[] args)
        {
            double gold = (1 + Math.Sqrt(5)) / 2;
            double A = 2;
            double B = 1;
            double a = 0;
            double b = 4;
            double accuracy = 0.0000001;
            double result_a = 0;
            double result_b = 0;
            double result_x = 0;
            while (b - a > accuracy)
            {
                double c = a + (b - a) / gold;
                double x = a + b - c;
                if (c > x)
                {
                    if (1 / (c * c + A * c - B) > 1 / (x * x + A * x - B))
                    {
                        b = c;
                    }
                    else
                    {
                        a = x;
                    }
                }
                else
                {
                    if (c < 1 / (c * c + A * c - B))
                    {
                        a = c;
                    }
                    else
                    {
                        b = x;
                    }
                }
                result_a = a;
                result_b = b;
                result_x = x;
            }

            Console.WriteLine("Итоговый результат");
            Console.WriteLine("Начало отрезка: " + result_a);
            Console.WriteLine("Конец отрезка: " + result_b);
            Console.WriteLine("Точка экстремума: " + result_x);
            Console.ReadKey();
        }
    }
}
