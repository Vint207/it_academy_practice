﻿using System;
using System.Collections;


namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateCollection();
            FindMaxNumb();
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

                if (i > 0 && a1[i] > numb)
                {
                    numb = a1[i];
                }
            }

            Console.WriteLine(string.Join(" ", a1));
            Console.WriteLine($"Максимальное число: {numb}");
        }   
    }
}