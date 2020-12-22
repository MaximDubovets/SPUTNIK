using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");                             //СУММА ПРОМЕЖУТКА ЧИСЕЛ
            Console.WriteLine("Введите минимальное число");
            int n_min = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальное число");
            int n_max = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = n_min; i <= n_max; i++)
            {
                sum = sum + i;
                //Console.WriteLine(i);
            }
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Нажмите любую клавишу для выхода");
            Console.ReadLine();
        }
    }
}
