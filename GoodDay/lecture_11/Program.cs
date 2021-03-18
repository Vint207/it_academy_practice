using static System.Console;

namespace lecture_11
{
    class Program
    {
        static void Main()
        {
            Figures<Figure> figures = new Figures<Figure>();

            figures.figures.Add(new Rectangle(10, 10));
            figures.figures.Add(new Rectangle(20, 20));
            figures.figures.Add(new Triangle(10, 10));
            figures.figures.Add(new Triangle(20, 20));
            figures.figures.Add(new Circle(10));

            foreach (var item in figures.figures) 
            { WriteLine($"This is {item.GetType()}. Area {item.Area()}"); }
                        
        }
    }
}
