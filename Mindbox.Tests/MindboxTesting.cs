using Mindbox.ClassLibrary;

namespace Mindbox.Tests
{
    [TestClass]
    public class MindboxTesting
    {
        [TestMethod]
        public void CalcCircle()
        {
            IFigure circle = new Circle(2);

            var expected = 12.566371;
            var result = circle.SquareCalc();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CalcTriangle()
        {
            IFigure triangle = new Triangle(4, 3, 5);

            var expected = 6d;
            var result = triangle.SquareCalc();

            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void CalcRectTriangle()
        {
            IFigure triangle = new Triangle(20, 21, 29);

            var expected = 210d;
            var result = triangle.SquareCalc();

            Assert.AreEqual(expected, result);
        }
    }
}