using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometryShape;

namespace TestsShape
{
    public class TestsRectangle
    {

        const double CHECKING_AREA = 15;
        const double CHECKING_PERIMETER = 16;

        [Fact]
        public void CheckingRectangle_Area()
        {

            GeometryShape.Rectangle rectangle = new(3, 5);

            Assert.Equal(CHECKING_AREA, rectangle.Area());
        }
        [Fact]
        public void CheckingRectanglePerimeter()
        {

            GeometryShape.Rectangle rectangle = new(3, 5);

            Assert.Equal(CHECKING_PERIMETER, rectangle.Perimeter());
        }
        [Theory]
        [InlineData(-5, 5)]
        [InlineData(0, 2)]
        public void CheckingProcessingIncorrectDataRectangle(double Width, double Height)
        {
            Assert.Throws<ArgumentException>(() => new GeometryShape.Rectangle(Width, Height));
        }
        [Fact]
        public void CheckingProcessingCorrectDataRectangle()
        {
            GeometryShape.Rectangle rectangle = new(3, 5);
            Assert.Equal(3, rectangle.Width);
            Assert.Equal(5, rectangle.Height);
        }
    }
}
