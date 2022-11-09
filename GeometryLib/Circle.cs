using System;

namespace GeometryLib
{
    internal class Circle
    {
        public double radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value >= 0)
                    radius = value;
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
