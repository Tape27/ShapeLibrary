using ShapeLibrary.Domain.Shapes.Interface;

namespace ShapeLibrary.Domain.Shapes
{
    public class Circle : Shape, ICircle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double CalcArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
