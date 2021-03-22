using System.Collections.Generic;
using static System.Console;

namespace lecture_11
{
    class Program
    {
        static void Main()
        {
            List<Figure> figures = new List<Figure>();

            figures.Add(new Rectangle(10, 10));
            figures.Add(new Rectangle(20, 20));
            figures.Add(new Triangle(10, 10));
            figures.Add(new Triangle(20, 20));
            figures.Add(new Circle(10));

            foreach (var item in figures) 
            { WriteLine($"This is {item.GetType()}. Area {item.Area()}"); }
                        
        }
    }
}
