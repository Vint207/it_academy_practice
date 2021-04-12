using System;
using System.Reflection;

namespace lecture_14
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Привет, мир";
            
            Console.WriteLine(s.CharCut());

            Product product = new Product();

            Type prod = typeof(Product);

            PropertyInfo piInstance = prod.GetProperty("_id");
            piInstance.SetValue(product, 37);

            //prod.GetType().GetField("_id").SetValue(product, 123);
           // prod.GetType().GetField("Name").SetValue(product, "IPhone 12 Pro");
          //  prod.GetType().GetField("ProductType").SetValue(product, "IPhone 12 Pro");
        }
    }
}
