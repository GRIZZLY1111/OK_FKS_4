using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryShape
{
    public class Triangle : Shape
    {
        public double SideA;
        public double SideB;
        public double SideC;
        public override double Area()
        {
            double poluPerimeter = (SideA + SideB + SideC)/2;
            double area = Math.Sqrt((poluPerimeter*(poluPerimeter-SideA)* (poluPerimeter - SideB)* (poluPerimeter - SideC)));
            return area;
        }
        public override double Perimeter()
        {
            double perimeter = SideA + SideB + SideC;
            return perimeter;
        }
        public override string ToString()
        {
            string str =  $"Это треугольник и его первая сторона равна {SideA}, его вторая сторона равна {SideB} " +
                $"и его третья сторона равна {SideC}. \n" +
                $"Его площадь равна {Area()}, а его периметр равен{Perimeter()}";
            return str;
        }
    }
}
