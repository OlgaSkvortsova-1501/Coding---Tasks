using System;

namespace Сортировка_Пузырьком
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int[] mas = new int[7];
                do
                {
                    try
                    {
                        Console.WriteLine("Введите числа для сортировки:");
                        Console.ReadLine();
                        for (int i = 0; i < mas.Length; i++)
                        {
                            mas[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Введите числа.");
                    }

                }
                while (true);

                Console.WriteLine("Выберите способ сортировки: \n1. Полная сортировка пузырьком \n2. Альтернативная сортировка пузырьком \n3. Выход");
                int a = Convert.ToInt32(Console.ReadLine());




                if (a == 1)
                {
                    Console.WriteLine("Выберите: \n1. по возрастанию \n2. по убыванию ");
                    int b = Convert.ToInt32(Console.ReadLine());

                    if (b == 1)
                    {

                        BubbleSoft(mas);
                        Console.WriteLine("После сортировки:");
                        for (int i = 0; i < mas.Length; i++)
                        {
                            Console.WriteLine(mas[i]);
                        }
                        Console.ReadLine();
                    }
                    if (b == 2)
                    {

                        BubbleSoft1(mas);
                        Console.WriteLine("После сортировки:");
                        for (int i = 0; i < mas.Length; i++)
                        {
                            Console.WriteLine(mas[i]);
                        }
                        Console.ReadLine();
                    }

                }
                if (a == 2)
                {
                    BubbleSoft2(mas);
                    Console.WriteLine("После сортировки четных чисел:");
                    for (int i = 0; i < mas.Length; i = i + 2)
                    {
                        Console.WriteLine(mas[i]);
                    }
                    Console.ReadLine();

                    Console.WriteLine("После сортировки нечетных чисел:");
                    for (int i = 1; i < mas.Length; i = i + 2)
                    {
                        Console.WriteLine(mas[i]);
                    }
                    Console.ReadLine();
                }
                if (a == 3)
                {
                    Console.WriteLine("Пока");
                    break;
                }
                else
                {
                    Console.WriteLine("Просто Ошибка");
                }


            }
            while (true);


            static int[] BubbleSoft(int[] mas)
            {
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] > mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                return mas;
            }

            static int[] BubbleSoft1(int[] mas)
            {
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] < mas[j])
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                return mas;
            }

            static int[] BubbleSoft2(int[] mas)
            {
                int temp;
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 2; j < mas.Length; j = j + 2)
                    {
                        if (( i % 2 == 0 && mas[i] < mas[j]) || (i % 2 != 0 && mas[i] > mas[j]))
                        {
                            temp = mas[i];
                            mas[i] = mas[j];
                            mas[j] = temp;
                        }
                    }
                }
                return mas;




            }

        }    
    }
}
