using System;
using static System.Console;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}");

            if (DateTime.Now.Hour > 8 & DateTime.Now.Hour < 12)
            {
                WriteLine("Good morning, guys");
            }
            else if (DateTime.Now.Hour > 11 & DateTime.Now.Hour < 15)
            {
                WriteLine("Good day, guys");
            }
            else if (DateTime.Now.Hour > 14 & DateTime.Now.Hour < 23)
            {
                WriteLine("Good evening, guys");
            }
            else
            {

            }
        }
    }
}
