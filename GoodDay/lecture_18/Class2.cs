using lecture_18;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace lecture_18
{
    class MotorcyclesArray
    {
        public Motorcycle[] arr = new Motorcycle[5];

        public MotorcyclesArray()
        {
            arr[0] = new Motorcycle { Model = "Minsk X250", MadeIn = "China", Odometer = 6_000 };
            arr[1] = new Motorcycle { Model = "Honda CB500F", MadeIn = "Japan", Odometer = 11_500 };
            arr[2] = new Motorcycle { Model = "BMW G1200R", MadeIn = "Germany", Odometer = 20_000 };
            arr[3] = new Motorcycle { Model = "Triumph Tiger 800", MadeIn = "China", Odometer = 30_000 };
            arr[4] = new Motorcycle { Model = "Honda CB1100RR", MadeIn = "Japan", Odometer = 26_000 };
        }
    }
}

