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
        public double Width;
        public double Height;
        public Rectangle(double width, double height)
        {
            try
            {
                Width = width;
                Height = height;

                if (Height <= 0 || Width <= 0)
                    throw new ArgumentException("Сторона не может быть отрицательна или равна нулю");
            }
            catch
            {
                throw new ArgumentException("Ошибка введены не цифры. Пожалуйста введите цифры!");
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
