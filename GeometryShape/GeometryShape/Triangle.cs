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

        public Triangle(double sideA, double sideB, double sideC)
        {
            try
            {
                SideA = sideA;
                SideB = sideB;
                SideC = sideC;

                if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                {
                    throw new ArgumentException("Сторона не может быть отрицательна или равна нулю");
                }

                if (SideB * SideB + SideC * SideC <= SideA*SideA || 
                    SideA * SideA + SideC * SideC <= SideB*SideB || SideA*SideA + SideB*SideB <= SideC*SideC)
                {
                    throw new ArgumentException("Квадрат гипотенузы не может быть больше квадратов катетов");
                }
            }
            catch
            {
                throw new ArgumentException("Ошибка введены не цифры. Пожалуйста введите цифры!");
            }
        }

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
