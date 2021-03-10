using System;

namespace Lecture10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Motorcycle moto = new Motorcycle();
                Console.WriteLine("Введите модель:");
                moto.Model = Console.ReadLine();
                Console.WriteLine("Введите производителя:");
                moto.Creator = Console.ReadLine();
                Console.WriteLine("Введите пробег:");
                moto.Stat = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите объем:");
                moto.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите мощность:");
                moto.Power = int.Parse(Console.ReadLine());
                Motorcycle.listMoto.Add(moto);
            }

            foreach (var item in Motorcycle.listMoto)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Creator);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Stat);
                Console.WriteLine(item.Year);
                Console.WriteLine(item.Power);
                Console.WriteLine(item.Volume);
            }
        }
    }
}
