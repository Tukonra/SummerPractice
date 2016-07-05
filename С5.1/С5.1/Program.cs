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
            int n = Convert.ToInt32(Console.ReadLine());
            int k = Convert.ToInt32(Console.ReadLine());

            int[,] a = new int[n, k];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                {
                    a[i, j] = random.Next(100);
                    Console.Write("{0,4}", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
