using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task.Model.Figures;

namespace Task.Model.Tests
{
    [TestClass()]
    public class FigureTests
    {
        [TestMethod()]
        public void GetSquareOfAnyFigureTest()
        {
            // Вычисление площади фигуры без знания типа фигуры
            Figure[] figures = new Figure[]
            {
                new Circle(1),
                new Triangle(9, 8, 7)
            };

            Assert.AreEqual(3.14, Math.Round(figures[0].GetSquare(), 2));
            Assert.AreEqual(26.83, Math.Round(figures[1].GetSquare(), 2));
        }
    }
}