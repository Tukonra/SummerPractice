using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double s = 0;

            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n <= 0) Console.WriteLine("Значение введено некорректно!");

            double[] array = new double[n];                                      //Объявление массива
            Random rnd = new Random();

            int k = n - 1;
            for (int i = 0; i <= k; i++)                                        //Заполнение массива
            {
                array[i] = rnd.Next(0,100);
                if (array[i] % 3 == 0) array[i] = array[i] * array[i];          //1 случай 
                else if (array[i] % 3 == 1) array[i] = array[i];                //2 случай
                else array[i] = array[i] / 3;                                   //3 случай
                s += array[i];                                                  //Подсчет суммы
            }
            Console.WriteLine();
            Console.Write("Сумма: ");
            Console.Write(+s);
            Console.ReadKey();
        }
    }
}
