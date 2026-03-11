using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Rectangle : Shape
    {
        private double _width;
        public double Width 
        {
            get => _width;
            set{
                if (_width != value)
                {
                    _width = value;
                }
            }
        }
        private double _height;
        public double Height
        {
            get => _height;
            set
            {
                if (_height != value)
                {
                    _height = value;
                }
            }
        }
        public override double Area()
        {
            double area = Width * Height;
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = Width * 2 + Height * 2;
            return perimeter;
        }
        public override string ToString()
        {
            string str = $"Это прямоугольник и его ширина равна {Width}, его высота равна {Height}.\n" +
                $"Его площадь равна {Area()}, а его периметр равен {Perimeter()}";
            return str;
        }
    }
}
