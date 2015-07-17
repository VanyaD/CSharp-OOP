using System;

namespace _01.Shapes
{
    public class Test
    {
        static void Main()
        {
            Shape[] myTestArray = 
            {
                new Square(5),
                new Square(3),
                new Square(10),
                new Rectangle(6, 4),
                new Rectangle(1, 2),
                new Rectangle(3, 5),
                new Triangle(2, 7),
                new Triangle(10, 9),
                new Triangle(8, 7)
            };

            foreach (Shape item in myTestArray)
            {
                Console.WriteLine(item.CalculateSurface());
            }
        }
    }
}
