using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2._1
{
    class Program
    {
        static void Main(string[] args)                                             //Задание 188
        {
            double summ = 0;
            int k = 0;

            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0) Console.WriteLine("Значение введено некорректно!");         //Проверка на корректность ввода

            double[] array = new double[n];                                         //Объявление массива
            Random rnd = new Random();
            for (int i = 0; i < n; i++)                       
            {
                array[i] = (rnd.NextDouble()-0.5)*100;                              //Заполнение массива

                if (array[i] < 2) array[i] = 0;                                     //Замена элемента < 2 на 0

                if (array[i] >= 3 && array[i] <= 7)                                 //Сумма элементов и их число на отрезке [3;7]
                {
                    summ += array[i];
                    k += 1;
                }
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();
            Console.Write("Сумма элементов последовательности: " + summ);
            Console.Write("\nЧисло элементов, принадлежащих отрезку [3,7] = " + k);
            Console.Read();
        }
    }
}
