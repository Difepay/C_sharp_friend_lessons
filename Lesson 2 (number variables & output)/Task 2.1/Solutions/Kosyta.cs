using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstLetter =  'A';
            char secondLetter = 'Z';
            Console.WriteLine($"First Alphabet letter: {firstLetter}.\nSecond Alphabet letter:{secondLetter}\nThere are {(decimal)secondLetter - (decimal)firstLetter + 1} letters in English alphabet");
            
            Console.Read();
        }
    }
}
