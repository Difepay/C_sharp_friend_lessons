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
			// Declare char variables
            char firstLet = 'A';
            char lastLet = 'Z';

            // Print output
            Console.WriteLine($"First Alphabet letter: '{firstLet}'.\nLast Alphabet letter: '{lastLet}'\nThere are {lastLet - firstLet + 1} letters in English alphabet.");

            Console.ReadKey();
        }
    }
}
