using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Run();
        }

        public static void Run()
        {
            int plus = 0;
            int minus = 0;
            string str_num;
           
            Console.WriteLine("Введите последовательность чисел, в завершение ноль");
            do
            {
                str_num = Console.ReadLine();
                try
                {
                    int num = Convert.ToInt32(str_num);
                }
                catch
                {
                    Console.WriteLine("Не число");
                    str_num = " ";
                    continue;
                }
                
                if (str_num[0] == '-')
                {
                    minus++;
                }
                else if (str_num[0] != '0')
                {
                    plus++;
                }
            }
            while (str_num.Length>0 & str_num[0] != '0');

            if (plus>minus)
            {
                Console.WriteLine("Положительных чисел больше, чем отрицательных: " + plus + " против " + minus);
            }
            else
            {
                Console.WriteLine("Отрицательных чисел больше, чем положительных: " + minus + " против " + plus);
            }
            Console.ReadLine();
            Run();
            Environment.Exit(0);
        }   
    }
}

