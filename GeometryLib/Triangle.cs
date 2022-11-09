using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace GeometryLib
{
    public class Triangle
    {
        public double[] sides { get; private set; }
        public Triangle(double a, double b, double c)
        {
            //Проверяем возможен ли такой треугольник
            var posSides = new double[] { a, b, c };
            posSides = posSides.OrderByDescending(x => x).ToArray();
            //Длина кратчайшей стороны должна быть положительна и
            //Сумма длин двух коротких сторон должна быть больше длины третьей
            if ((posSides[2] > 0) && (posSides[0] < posSides[1] + posSides[2]))
            {
                sides = posSides;
            }
            else
            {
                throw new ArgumentException("Invalid lengths of a sides");
            }
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
            //В конструкторе мы уже сортировали длины сторон, но дабы мсключить проблем при расширении класса проводим сортировку ещё раз в этом методе. 
            double[] copySides = sides.OrderByDescending(x => x).ToArray();
            return sides[0] * sides[0] == sides[1] * sides[1] + sides[2] * sides[2];

        }
    }
}
