using NUnit.Framework;
using NUnit.Framework.Legacy;
using ShapeLibrary.Domain.Shapes;

namespace ShapeLibrary.Tests.Shapes
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void TestArea()
        {
            var triangle = new Triangle(3, 4, 5);
            ClassicAssert.AreEqual(6, triangle.CalcArea(), 1);
        }

        [Test]
        public void TestIsRight()
        {
            var triangle = new Triangle(3, 4, 5);
            ClassicAssert.True(triangle.IsRight());
        }
    }

}
