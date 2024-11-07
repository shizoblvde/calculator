using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Math;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Clear(); 
                Write($"первое число: ");
                double.TryParse(ReadLine(), out double num1);
                Write($"действие( + -- сумма - -- разница * -- произведение / -- частное ^ -- возведение в степень % -- остаток от деления : ");
                string todo = ReadLine();
                Write($"второе число: ");
                double.TryParse(ReadLine(), out double num2);
                if (todo == "/" && num2 == 0) { Write("ошибка\n"); }
                else if (todo == "+") { Write($"решение: {num1 + num2} \n"); }
                else if (todo == "-") { Write($"решение: {num1 - num2} \n"); }
                else if (todo == "*") { Write($"решение: {num1 * num2}\n"); }
                else if (todo == "/" && num2 != 0) { Write($"решение: {num1 / num2}\n"); }
                else if (todo == "%") { Write($"решение: {num1 % num2}\n"); }
                else if (todo == "^") { Write($"решение: {Pow(num1, num2)}\n"); }
                else { Write("ошибка\n"); }
                Write("посчитать что то ещё раз? 1 - да все остальное - нет\n");
                if (ReadLine() != "1") { break; }
            }
        }
    }
}
