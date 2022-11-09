using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib
{
    internal class Triangle
    {
        public double[] sides { get; private set; }
        public Triangle(double a, double b, double c)
        {
           sides = new double[] { a, b, c };
        }

        public double Area()
        {
            //Используем формулу Герона, в этом случае нам не важен тип треугольника 
            double p = (sides[0] + sides[1] + sides[2]) / 2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2])); 
        }

        public bool isOrthogonal()
        {
            //Сортируем по убыванию, что бы не перебирать варианты
            double[] copySides = sides.OrderByDescending(x => x).ToArray();
            return sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2];

        }
    }
}
