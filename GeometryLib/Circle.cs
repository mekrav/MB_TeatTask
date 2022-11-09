using System;

namespace GeometryLib
{
    public class Circle
    {
        public double radius { get; private set; }

        public Circle(double r)
        {
            if(radius >= 0)
                radius = r;
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
