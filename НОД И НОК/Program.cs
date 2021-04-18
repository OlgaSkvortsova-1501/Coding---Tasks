using System;

namespace НОД_И_НОК
{
    class Program
    {
        static void Main(string[] args)
        {
            
            do
            { 
                Console.WriteLine("Введите первое, второе и третье число через Enter");
                int a = 0, b = 0, c = 0;
                bool jp = false;
                
                do
                {
                    jp = false;
                   
                    try
                    {
                        a = Convert.ToInt32(Console.ReadLine());    
                       
                        if (a <= 0)
                        {
                            jp = true;
                        }
                    }
                    catch (FormatException)
                    {
                        jp = true;
                        Console.WriteLine("Ошибка. Введите первое положительное ЧИСЛО.");
                    }
                }
                while (jp == true);

            

                do
                {
                    jp = false;
                    try
                    {
                        b = Convert.ToInt32(Console.ReadLine());
                        
                        if (b <= 0)
                        {
                            jp = true;
                        }
                    }
                    catch (FormatException)
                    {
                        jp = true;
                        Console.WriteLine("Ошибка. Введите второе положительное ЧИСЛО.");
                    }
                }
                while (jp == true);



                do
                {
                    jp = false;
                    try
                    {
                        c = Convert.ToInt32(Console.ReadLine());
                        
                        if (c <= 0)
                        {
                            jp = true;
                        }
                    }
                    catch (FormatException)
                    {
                        jp = true;
                        Console.WriteLine("Ошибка. Введите третье положительное ЧИСЛО.");
                    }
                    
                }
                while (jp == true);


                


                Console.Write("Результат NOD: ");
                Console.WriteLine(NOD(a, b, c));
                Console.Write("Результат NOK: ");
                Console.WriteLine(NOK(a, b, c));


            }
            while (true);
            

            static int NOD(int a, int b, int c)
            {

                int res;
                if ((a == b) && (b == c) && (c == a))
                {
                    return (a);
                }

                res = Math.Min(a, Math.Min(b, c));
                for (; res > 1; res--)
                {
                    if (a % res == 0 && b % res == 0 && c % res == 0)
                        break;
                }

                return res;

            }

            static int NOK(int a, int b, int c)
            {
                return (a * b * c) / NOD(a, b, c);

            }




        }
    }
}    
