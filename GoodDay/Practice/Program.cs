using System;
using System.Collections;
using static System.Convert;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateEmptyArray();
            CreateCollection();
            FindMaxNumb();
            Convert();
        }

        static void CreateEmptyArray()
        {
            int[] a = new int[0];
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

        static void FindMaxNumb()
        {
            int[] a1 = new int[13];
            int numb;

            Random rand = new Random();

            numb = 0;

            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                a1[i] = rand.Next(0, 100);

                if (a1[i] > numb)
                {
                    numb = a1[i];
                }
            }

            Console.WriteLine(string.Join(" ", a1));
            Console.WriteLine($"Максимальное число: {numb}");
        }

        static void Convert()
        {
            short numb1;
            object numb2;
            sbyte numb3;

            numb1 = 100;
            Console.WriteLine($"{numb1} типа {numb1.GetTypeCode()}");

            //Упаковка
            numb2 = numb1;
            Console.WriteLine($"{numb2} типа object");
            
            //Распаковка
            numb3 = ToSByte(numb2);
            Console.WriteLine($"{numb3} типа {numb3.GetTypeCode()}");
        }
    }
}
