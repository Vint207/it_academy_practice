namespace lecture_18
{
    class Program
    {
        delegate bool MotorcycleDelegat1(Motorcycle obj, int val = 0, string country = null, int state = 0);


        static void Main(string[] args)
        {
            Motorcycle motorcycle = new();
            MotorcycleDelegat1 del = new MotorcycleDelegat1(MethodToDelegat);

            Motorcycle FirstOrDefault(MotorcyclesArray list, MotorcycleDelegat1 arg)
            {
                foreach (var item in list.arr)
                {
                    if (arg.Invoke(item, val: 50000, state: 1))
                    {
                        return item;
                    }
                }
                return null;
            }
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

                case 3  :
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
