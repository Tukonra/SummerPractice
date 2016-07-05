using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            int u, v;
            double k;

            u = Math.Min(a,b);
            v = Math.Min(a * b, a + b);
            k = Math.Min(u+(v*v),3.14);
            Console.Write("min(a,b) = ");
            Console.WriteLine(u);
            Console.Write("min(ab, a+b) = ");
            Console.WriteLine(v);
            Console.Write("min(u+(v*v), 3.14) = ");
            Console.WriteLine(k);
            Console.ReadKey();
        }
    }
}
