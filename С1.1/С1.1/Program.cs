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
            Console.WriteLine("Введите первое число");                  //Ввод числа x
            int x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число");                  //Ввод числа a
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите третье число");                  //Ввод числа e
            int e = Convert.ToInt32(Console.ReadLine());

            double y, y0;
            y0 = a;
            double y1;//i-й y
            for (;;)
            {
                y = y0;
                y0 = y1 = 0.5 * (y + x / y);
                if (Math.Abs(y1 * y1 - y * y) < e) break;
            }

            Console.Write("Первый член последовательности - ");
            Console.WriteLine(y1.ToString());
            Console.ReadKey();
        }
    }
}
