using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace распределение_заданий
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество заданий для выполнения");
            int[] tasks = new int[Convert.ToInt32(Console.ReadLine())];
            int[,] work = new int[tasks.Length, tasks.Length];
            int[] best = new int[tasks.Length];
            int[] Gs = new int[tasks.Length];
            int[] comparison_ogr = new int[tasks.Length];
            int[] best_ogr = new int[tasks.Length];
            int[] worst = new int[tasks.Length];
            for (int i = 0; i < tasks.Length; i++)
            {

                int[] comparison = new int[tasks.Length];
                for (int f = 0; f < tasks.Length; f++)
                {
                    Console.WriteLine("Введите цену задания " + (f + 1) + " для работника " + (i + 1));
                    int price = Convert.ToInt32(Console.ReadLine());
                    work[i, f] = price;
                    comparison[f] = price;

                }
                Gs[i] = Array.IndexOf(comparison, comparison.Min());
                best[i] = comparison.Min();
                worst[i] = comparison.Sum();
                
            }//4 7 1
             //5 3 7
             //3 6 2
            for(int z = 0; z < tasks.Length; z++)
            {
                for(int x = z+1; x < tasks.Length; x++)
                {
                    work[x,Gs[z]] = worst[x];
                }
            }
            for (int f = 0; f < tasks.Length; f++)
            {
                for(int c = 0;c<tasks.Length;c++)
                {
                    comparison_ogr[c] = work[f,c];
                }

                best_ogr[f] = comparison_ogr.Min();
            }
            Console.WriteLine("Верхняя граница: " + best_ogr.Sum());
            Console.WriteLine("Нижняя граница: " + best.Sum());
            Console.ReadLine();
        }
    }
}
