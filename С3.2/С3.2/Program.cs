using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С3._2
{
    class Program
    {
        static void Main(string[] args) //280
        {
            int b = 0;
            float[] x = new float[26];
            float[] y = new float[26];

            x[1] = 1;                     //Задаем начальные данные
            y[1] = 1;
            x[2] = 2;
            y[2] = 2;

            for (int i = 1; i <= 25; i++)
            {
                if (i > 2)
                {
                    x[i] = Program.getX(i, y[i - 1], y[i - 2]);
                    y[i] = Program.getY(i, x[i - 1], x[i - 2], y[i - 1]);
                }

                b++;
                Console.Write("" + b + " ");
                Console.Write(x[i]);
                Console.Write(", ");
                Console.Write("" + b + " ");
                Console.Write(y[i]);
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static float getX(int i, float y1, float y2)
        {
            return (y1 - y2) / i;
        }

        static float getY(int i, float x1, float x2, float y1)
        {
            return (x1 * x1 + x2 + y1) / Program.factorial(i);
        }

        static int factorial(int i)
        {
            return (i == 0) ? 1 : (i * Program.factorial(i - 1));
        }
    }
}
