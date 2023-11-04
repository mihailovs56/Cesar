using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Цезарь
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string a = Console.ReadLine();
            Console.WriteLine("Введите число для сдвига: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int c;
            char[] d = a.ToCharArray();
            char[] e = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            for (int i = 0; i < d.Length; i++)
            {
                for (c = 0; c < e.Length; c++)
                {
                    if (d[i] == e[c])
                    {
                        break;
                    }
                }
                if (c < 32)
                {
                    int f = c + b;
                    if (f > 32)
                    {
                        f = f - 33;
                    }
                    d[i] = e[f];
                }
            }
            string g = new string(d);
            Console.WriteLine("Зашифрованная строка " + g);
            char[] h = g.ToCharArray();

            Console.WriteLine("Введи зашифрованную строку: ");
            string ab = Console.ReadLine();
            Console.WriteLine("Введите число сдвига: ");
            int ba = Convert.ToInt32(Console.ReadLine());
            char[] ac = ab.ToCharArray();
            for (int ai = 0; ai < ac.Length; ai++)
            {
                for (c = 0; c < e.Length; c++)
                {
                    if (ac[ai] == e[c])
                    {
                        break;
                    }
                }
                if (c < 32)
                {
                    int af = c - b;
                    if (af > 32)
                    {
                        af = af + 33;
                    }
                    ac[ai] = e[af];
                }
            }
            string ag = new string(ac);
            Console.WriteLine("Зашифрованная строка " + ag);
            char[] ah = ag.ToCharArray();
        }
    }
}
