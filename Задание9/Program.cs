using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вас приветствует калькулятор!\n");
            Console.Write("Введите целое число: x =\t");
            int x = 0;
            try
            {
               x = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Введите целое число: y =\t");
            int y = 0;
            try
            {
                y = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Write("Введите код операции: \n 1 - cложение \n 2 - вычитание \n 3 - произведение \n 4 - частное \n Ваш выбор:\t");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n  < 1 || n > 4)
            {
                Console.WriteLine("Нет операции с указанным номером");
            }           
            if (n == 1)
                {
                    Console.WriteLine("Результат:{0} ", (x + y));
                }
                if (n == 2)
                {
                    Console.WriteLine("Результат:{0} ", (x - y));
                }
                if (n == 3)
                {
                    Console.WriteLine("Результат:{0} ", (x * y));
                }
            try
            {
                if (n == 4)
                {
                    Console.WriteLine("Результат:{0} ", (x / y));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
