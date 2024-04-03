using ShapeLibrary.Domain.Shapes;
using ShapeLibrary.Domain.Shapes.Interface;

namespace ShapeLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape triangle = new Triangle(1, 2, 3);
        }
    }
}
