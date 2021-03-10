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
                Motorcycle.Engine eng = new Motorcycle.Engine();
                Console.WriteLine("Введите модель:");
                moto.Model = Console.ReadLine();
                Console.WriteLine("Введите производителя:");
                moto.Creator = Console.ReadLine();
                Console.WriteLine("Введите пробег:");
                moto.Stat = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите объем:");
                eng.Volume = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите мощность:");
                eng.Power = int.Parse(Console.ReadLine());
                ListMoto.listMoto.Add(moto);
            }

            foreach (var item in ListMoto.listMoto)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Creator);
                Console.WriteLine(item.Model);
                Console.WriteLine(item.Stat);
                Console.WriteLine(item.Year);
            }
        }
    }
}
