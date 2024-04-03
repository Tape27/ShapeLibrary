using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeLibrary.Domain.Shapes.Interface
{
    public interface ITriangle
    {
        double sideA { get; set; }
        double sideB { get; set; }
        double sideC { get; set; }
        bool IsRight();
    }
}
