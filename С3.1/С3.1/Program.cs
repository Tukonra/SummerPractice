using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            int n = Convert.ToInt32(Console.ReadLine());

            char[] array = new char[n];                                           //Объявление массива
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToChar(rnd.Next('*' , '*' + 27));              //Заполнение массива
                Console.Write("{0} ", array[i]);

                if  (array[i] == '*') array[i] = ' ';                              //Замена элемента
                else  Console.Write(array[i]);                                    //Повторение элемента
               
            }

            Console.ReadKey();
        }
    }
}

