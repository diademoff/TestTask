using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO: add more tests
namespace Task.Model.Figures.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void GetSquareTest()
        {
            Assert.AreEqual(6, new Triangle(3, 4, 5).GetSquare());
        }

        [TestMethod()]
        public void IsRightTest()
        {
            Assert.AreEqual(true, new Triangle(3, 4, 5).IsRight);
            Assert.AreEqual(false, new Triangle(5, 4, 5).IsRight);
        }
    }
}