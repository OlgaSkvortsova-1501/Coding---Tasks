using System;

namespace Калькулятор_Функции
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число, операцию и второе число через Enter.");

            double a, b;
            char operation;
            char[] operations = { '+', '-', '*', '/', '^' };

            do
            {
               
                try
                {
                    a = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Введите первое ЧИСЛО.");
                }
            }
            while (true);

            do
            {
                string value = Console.ReadLine();
                if (value.Length > 0)
                {
                    operation = value[0];

                    if (value.Length != 1 || Array.IndexOf(operations, operation) == -1)
                    {
                        Console.WriteLine("Ошибка. Такой операции не существует");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка. ВВЕДИТЕ операцию");
                }
            }
            while (true);
            
            do
            {
                try
                {
                    b = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка. Введите второе ЧИСЛО.");
                }
            }
            while (true);

            if (operation == '/' && b == 0)
            {
                Console.WriteLine("Ошибка. НЕЛЬЗЯ делить на 0.");
            } else
            {
                Console.Write("Результат: ");
                Console.WriteLine(Calculate(a, operation, b));
            }
        }

        static double Calculate(double a, char operation, double b)
        {
            switch (operation)
            {
                case '+':
                    return Add(a, b);
                case '-':
                    return Subtract(a, b);
                case '*':
                    return Multiply(a, b);
                case '/':
                    return Divide(a, b);
                case '^':
                    return Power(a, b);
                default:
                    return 0;
            }
        }

        static double Add(double a, double b)
        {
            return (a + b);
        }
        
        static double Subtract(double a, double b)
        {
            return (a - b);
        }
       
        static double Multiply(double a, double b)
        {
            return (a * b);
        }
       
        static double Divide(double a, double b)
        {
            return (a / b);
        }
        
        static double Power(double a, double power)
        {
            return Math.Pow(a, power);
        }
    
    
    }   
     
}


