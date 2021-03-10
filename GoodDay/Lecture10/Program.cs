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
                ListMoto.listMoto.Add(moto);
            }
        }
    }
}
