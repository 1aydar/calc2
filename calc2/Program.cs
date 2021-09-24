using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc2
{
    class Program
    {
        static void Main(string[] args)
        {
            double first_num, second_num, r_add, r_sub, r_mult, r_div;
            Console.WriteLine("Программа калькулятор v 1.1, автор Aydar \nДля продолжения нажмите Enter.");
            Console.ReadLine();
            Console.WriteLine("Введите первое число и нажмите Enter");
            first_num = Double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число и нажмите Enter");
            second_num = Double.Parse(Console.ReadLine());
            r_add = (first_num + second_num);
            r_sub = (first_num - second_num);
            r_mult = (first_num * second_num);
            r_div = (first_num / second_num);
            Console.WriteLine("Для сложения этих чисел нажмите A, для вычитания нажмите S, \nдля умножения нажмите M, для деления нажмите D.");
            string show = Console.ReadLine();
            switch (show)
            {
                case "A":
                case "a":
                    Console.WriteLine("Результат сложения: " +r_add);
                    break;
                case "S":
                case "s":
                    Console.WriteLine("Результат вычитания: " +r_sub);
                    break;
                case "M":
                case "m":
                    Console.WriteLine("Результат умножения: "+r_mult);
                    break;
                case "D":
                case "d":
                    Console.WriteLine("Результат деления: "+r_div);
                    break;
            }

        }
    }
}
