using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCircled;

namespace Test
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void SquareСircleTest()
        {
            Square testClass = new Square();
            var result = testClass.SquareFigyre(2, 2);
            Assert.AreEqual(12.56, result);
        }
        [TestMethod]
        public void SquareTriangleTest()
        {
            Square testClass = new Square();
            var result = testClass.SquareFigyre(10, 12, 13, 2);
            Assert.AreEqual(57, result);
        }
        [TestMethod]
        public void RightTriangleTestTrue()
        {
            Square testClass = new Square();
            var result = testClass.RightTriangle(5, 12, 13, 2);
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void RightTriangleTestFalse()
        {
            Square testClass = new Square();
            var result = testClass.RightTriangle(6, 12, 13, 2);
            Assert.AreEqual(false, result);
        }
    }
}
