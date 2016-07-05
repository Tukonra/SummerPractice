using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число строк - ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите число столбцов - ");
            int k = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер строки для удаления - ");
            int o = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер столбца для удаления - ");
            int p = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[n, k];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    a[i, j] = random.Next(100);                         //Заполнение массива рандомными числами
                    a[o-1, j] = 0;                                      //Удаление строки
                    a[i, p-1] = 0;                                      //Удаление столбца
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
