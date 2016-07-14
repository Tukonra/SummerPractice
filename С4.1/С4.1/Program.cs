using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace С4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символьную строку"); ;
            string text = Convert.ToString(Console.ReadLine());

            List<char> chars = new List<char>();

            int c, ff, sf;
            bool bf, af;

            bool f;

            for (int i = 0; i < text.Length; i++)
            {
                c = 0;
                ff = -1;
                sf = -1;
                af = false;
                bf = false;

                for (int j = 0; j < text.Length; j++)
                {
                    if (ff != -1)
                    {
                        if (text[j] == 'a')
                            af = true;

                        if (text[j] == 'b')
                            bf = true;
                    }

                    if (text[i] == text[j])
                    {
                        c++;

                        if (ff == -1)
                            ff = text[j];

                        sf = text[j];
                    }
                }

                if (c > 1 && bf && af)
                {
                    f = false;

                    foreach (char ch in chars)
                        if (ch == text[i])
                            f = true;

                    if (!f)
                        chars.Add(text[i]);
                }
            }

            foreach (char ch in chars)
                Console.WriteLine(ch);

            Console.ReadKey();
        }
    }
}
