using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С5._2
{
    class Program
    {
        static void Main(string[] args) //428
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            int u, v;
            double k;

            u = Math.Min(a,b);                                  //Определение минимума для первого действия
            v = Math.Min(a * b, a + b);                         //Определение минимума для второго действия
            k = Math.Min(u+(v*v),3.14);                         //Определение минимума для третьего действия
            Console.WriteLine("min(a,b) = "+u+"");
            Console.WriteLine("min(ab, a+b) = "+v+"");
            Console.WriteLine("min(u+(v*v), 3.14) = "+k+"");
            Console.ReadKey();
        }
    }
}
