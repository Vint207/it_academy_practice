namespace lecture_18
{
    class Program
    {
        delegate bool MotorcycleDelegat1(Motorcycle obj, int val = 0, string country = null, int state = 0);


        static void Main(string[] args)
        {
            Motorcycle motorcycle = new();
            MotorcyclesArray motorcyclesArray = new();
            MotorcycleDelegat1 del = new MotorcycleDelegat1(MethodToDelegat);

            FirstOrDefault(motorcyclesArray, del, val: 50000, state: 1);
            FirstOrDefault(motorcyclesArray, del, country: "China", state: 2);
            FirstOrDefault(motorcyclesArray, del, val: 50000, country: "China", state: 3);

        }

        static Motorcycle FirstOrDefault(MotorcyclesArray list, MotorcycleDelegat1 arg, int val = 0, string country = null, int state = 0)
        {
            foreach (var item in list.arr)
            {
                if (arg.Invoke(item, val, country, state))
                {
                    return item;
                }
            }
            return null;
        }

        static bool MethodToDelegat(Motorcycle obj, int val = 0, string country = null, int state = 0)
        {
            switch (state)
            {
                case 1:
                    if (obj.Odometer >= val)
                    {
                        return true;
                    }
                    return false;

                case 2:
                    if (obj.MadeIn == country)
                    {
                        return true;
                    }
                    return false;

                case 3:
                    if (obj.MadeIn == country && obj.MadeIn == country)
                    {
                        return true;
                    }
                    return false;
            }
            return false;
        }
    }
}
