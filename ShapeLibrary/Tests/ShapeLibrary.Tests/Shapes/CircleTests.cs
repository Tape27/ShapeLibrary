using NUnit.Framework.Legacy;
using NUnit.Framework;
using ShapeLibrary.Domain.Shapes;

namespace ShapeLibrary.Tests.Shapes
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void TestArea()
        {
            var circle = new Circle(2);
            ClassicAssert.AreEqual(12.566370614359172, circle.CalcArea(), 10);
        }
    }
}