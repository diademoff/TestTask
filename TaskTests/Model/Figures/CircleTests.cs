using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO: add more tests
namespace Task.Model.Figures.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void GetSquareTest()
        {
            Assert.AreEqual(78.54, Math.Round(new Circle(5).GetSquare(), 2));
        }
    }
}