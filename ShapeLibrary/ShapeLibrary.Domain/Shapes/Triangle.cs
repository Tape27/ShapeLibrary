using ShapeLibrary.Domain.Shapes.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Domain.Shapes
{
    public class Triangle : Shape, ITriangle
    {
        public double sideA { get; set; }
        public double sideB { get; set; }
        public double sideC { get; set; }

        public Triangle(double sidea, double sideb, double sidec)
        {
            sideA = sidea;
            sideB = sideb;
            sideC = sidec;
        }
        public override double CalcArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public bool IsRight()
        {
            return Math.Abs(Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) < 0.1;
        }
    }
}
