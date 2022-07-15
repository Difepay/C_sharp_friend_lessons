using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задаём переменные нужные для первого способа
            byte day = 28;
            byte month = 03;
            ushort year = 2006;
			
            // Задаём переменную необходимую для второго способа
            char daych = 'X';
            char dyach1 = '<';
			
            // Вывод первого способа
            Console.WriteLine($"My brithday: {day}/{month}/{year}");
			
            // Вывод второго способа
            Console.WriteLine($"My brithday: {(decimal)daych - (decimal)(dyach1)}/{month}/{year}");
            Console.Read();
        }
    }
}
