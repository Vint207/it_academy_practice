using System;

namespace lecture_12
{
    class Program
    {
        static void Main(string[] args)
        {
            UniqueItem item1 = new();
            UniqueItem item2 = new();
            UniqueItem item3 = new();

            UniqueItem item4 = new(100);
            UniqueItem item5 = new();
            UniqueItem item6 = new();

            Console.WriteLine(item1.id);
            Console.WriteLine(item2.id);
            Console.WriteLine(item3.id);
            Console.WriteLine(item4.id);
            Console.WriteLine(item5.id);
            Console.WriteLine(item6.id);
        }
    }
}
