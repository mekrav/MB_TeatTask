using System;
using System.Net.Http.Headers;

namespace GeometryLib
{
    public class Circle
    {
        public double radius { get; private set; }

        public Circle(double r)
        {
            Console.WriteLine(r);
            if (r >= 0)
            {
                radius = r;
            }
            else
            {
                throw new ArgumentException("Radius mast be grater then 0");
            }
        }

        /// <summary>
        /// Вычисляет площадь круга
        /// </summary>
        public double Area()
        {
            // Можно так же использовать Math.Power()
            return Math.PI * radius * radius;
        }
    }
}
