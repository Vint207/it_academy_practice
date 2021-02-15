using System;
using static System.Console;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int count;

            WriteLine("Введите слово:");
            word = ReadLine();
            count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a')
                {
                    count++;
                }
            }
            WriteLine($"Букв а в слове - {count}");
        }
    }
}
