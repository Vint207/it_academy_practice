namespace lecture_18
{
    class Program
    {
        delegate bool MotorcycleDelegat(Motorcycle obj, int val = 0, string country = null, int state = 0);


        static void Main(string[] args)
        {
            Motorcycle motorcycle = new();
            MotorcyclesArray motorcyclesArray = new();

            FirstOrDefault(motorcyclesArray, MethodToDelegat, val: 50000, state: 1);
            FirstOrDefault(motorcyclesArray, MethodToDelegat, country: "China", state: 2);
            FirstOrDefault(motorcyclesArray, MethodToDelegat, val: 50000, country: "Japan", state: 3);
        }

        static Motorcycle FirstOrDefault(MotorcyclesArray list, MotorcycleDelegat arg, int val = 0, string country = null, int state = 0)
        {
            foreach (var item in list.arr)
            {
                if (arg.Invoke(item, val, country, state)) {return item; }
            }
            return null;
        }

        static bool MethodToDelegat(Motorcycle obj, int val = 0, string country = null, int state = 0)
        {
            return state switch
            {
                1 when (obj.Odometer >= val) => true,
                2 when (obj.MadeIn == country) => true,
                3 when (obj.MadeIn == country && obj.MadeIn == country) => true,
                _ => false
            };
        }
    }
}
