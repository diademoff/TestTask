using System;
using System.Linq;

namespace Task.Model.Figures
{
    public class Triangle : Figure
    {
        public double SideA { get; private set; }
        public double SideB { get; private set; }
        public double SideC { get; private set; }

        public bool IsRight
        {
            get
            {
                double[] SidesSorted = new double[]
                {
                    SideA, SideB, SideC
                }.OrderByDescending(x => x).ToArray();

                return Math.Pow(SidesSorted[0], 2) == Math.Pow(SidesSorted[1], 2) + Math.Pow(SidesSorted[2], 2);
            }
        }

        /// <summary>
        /// Init triangle
        /// </summary>
        /// <param name="sideA">Length of the first side of the triangle</param>
        /// <param name="sideB">Length of the second side of the triangle</param>
        /// <param name="sideC">Length of the third side of the triangle</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (IsTriangleExists(sideA, sideB, SideC))
                throw new Exception("Triangle doesn't exist");

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public override double GetSquare()
        {
            double HalfSum = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(HalfSum * (HalfSum - SideA) * (HalfSum - SideB) * (HalfSum - SideC));
        }

        private bool IsTriangleExists(double a, double b, double c)
        {
            return a + b > c &&
                a + c < b &&
                b + c < a;
        }
    }
}
