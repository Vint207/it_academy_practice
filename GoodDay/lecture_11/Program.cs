using static System.Console;

namespace lecture_11
{
    class Program
    {
        static void Main()
        {

            object[] figures = new object[5];

            figures[0] = new Rectangle(10, 10);
            figures[1] = new Rectangle(20, 20);
            figures[2] = new Triangle(10, 10);
            figures[3] = new Triangle(20, 20);
            figures[4] = new Circle(10);

            foreach (var item in figures)
            {
                System.Type type = item.GetType();
                if (type == typeof(Rectangle)) 
                {
                    Rectangle temp = (Rectangle)item;
                    double area = temp.Area();
                    WriteLine($"This is Rectangle. Type {type}. Area {area} "); 
                }

                if (type == typeof(Triangle))
                {
                    Triangle temp = (Triangle)item;
                    double area = temp.Area();
                    WriteLine($"This is Triangle. Type {type}. Area {area} ");
                }

                if (type == typeof(Circle))
                {
                    Circle temp = (Circle)item;
                    double area = temp.Area();
                    WriteLine($"This is Circle. Type {type}. Area {area} ");
                }
            }
        }
    }
}
