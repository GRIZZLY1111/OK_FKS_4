using GeometryShape;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestsShape
{
    public class TestsTriangle
    {

        const double CHECKING_AREA = 4.15;
        const double CHECKING_PERIMETER = 11;

        [Theory]
        [InlineData(-2, 1, 1)]
        [InlineData(0, 3, 3)]
        [InlineData(3, 2, 2)]
        [InlineData(1, 2, 3)]
        public void CheckingProcessingIncorrectDataTriangle(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }
        [Fact]
        public void CheckingProcessingCorrectDataTriangle()
        {
            GeometryShape.Triangle triangle = new(3, 5, 3);
            Assert.Equal(3, triangle.SideA);
            Assert.Equal(5, triangle.SideB);
            Assert.Equal(3, triangle.SideC);
        }
        [Fact]
        public void CheckingTriange_Area()
        {

            GeometryShape.Triangle triangle = new(3, 5, 3);

            Assert.Equal(CHECKING_AREA, triangle.Area(), 0.01);
        }
        [Fact]
        public void CheckingTrianglePerimeter()
        {

            GeometryShape.Triangle triangle = new(3, 5, 3);

            Assert.Equal(CHECKING_PERIMETER, triangle.Perimeter());
        }
    }
}
