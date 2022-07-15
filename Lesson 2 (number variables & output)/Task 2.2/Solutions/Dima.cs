using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LESSON_1
{
    class Program
    {
        static void Main(string[] args)
        {
			// Required for the first way
            byte day = 30;
            byte month = 5;
            ushort year = 2006;

            // Required for the second way
            char zero = '0';
            char two = '2';
            char three = '3';
            char five = '5';
            char six = '6';

            // Print using first way
            Console.WriteLine($"My birthday is: {day}/{month}/{year}");

            // Print using second way
            Console.WriteLine($"My birthday is: {three}{zero}/{five}/{two}{zero}{zero}{six}");

            Console.ReadKey();
        }
    }
}
