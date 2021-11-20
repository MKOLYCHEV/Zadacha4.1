using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            if (num > 0)
            {
                for (int i = 1; i <= num; i++)
                {
                    a += 2 * i - 1;
                    Console.WriteLine("Квадрат числа {0} равен {1}", i, a);
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ошибка! Введено число меньше единицы.");
                Console.ReadKey();
            }
        }
    }
}
