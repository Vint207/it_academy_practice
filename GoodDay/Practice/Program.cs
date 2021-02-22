using System;
using System.Collections;


namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCollection();
        }

        static void CreateEmptyArray()
        {
            Console.WriteLine("Hello World!");
        }

        static void CreateCollection()
        {


            ArrayList list = new ArrayList() { 32, 'A', "Hello" };
           
            foreach (var item in list)
            {
                Console.Write($" {item}");
            }

            Console.WriteLine();

            list[0] = (int)list[0] + 10;
            list[2] = $"{list[2]}, Guys!";

            foreach (var item in list)
            {
                Console.Write($" {item}");
            }
        }

        
    }
}
