using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double b;

            Console.WriteLine("Введите первое число");                          //Ввод числа A1
            double a1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число");                          //Ввод числа A2
            double a2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите третье число");                          //Ввод числа A3
            double a3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите четвертое число");                       //Ввод числа A4
            double a4 = Convert.ToDouble(Console.ReadLine());

            double[] x = new double[51];                                        //Объявление массива
            Random rnd = new Random();

            for (int i = 1; i <= 50; i++)                       
            {
                x[i] = rnd.Next(-10,10);                                    //Заполнение массива рандомными числами
                b = ((x[i] * x[i] - a1) / (x[i] - a1)) * ((x[i] * x[i] * x[i] - x[i] - a2) / (x[i] - a2)) * (x[i] - a3) - ((x[i] * x[i] * x[i] * x[i] - x[i] - a4) / x[i]) + x[i] * (x[i] + a3);
                Console.Write("b");
                Console.Write(i);
                Console.Write(" =");
                Console.Write(b);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
