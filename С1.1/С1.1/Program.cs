using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, y1;
            int cnt = 0;

            Console.WriteLine("Введите первое число");                 //Ввод числа x
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");                 //Ввод числа a
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");
            int e = Convert.ToInt32(Console.ReadLine());
            
            y = a;
            y1 = y;

            double k = Math.Abs(y * y - y1 * y1);

            for (int i = 1; k < e; i++)
            {
                if (k < e)
                {
                    y1 = y;
                    y = 0.5 * (y1 + x / y1);
                    cnt = e;
                }
            }
            Console.Write("Первый член последовательности - ");
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    }
}
