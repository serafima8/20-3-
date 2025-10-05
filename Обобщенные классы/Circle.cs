using System;

namespace Обобщенные_классы
{
    public class Circle<T>
    {
        public T Radius { get; set; }

        public Circle(T radius)
        {
            Radius = radius;
        }

        public void Show()
        {
            Console.WriteLine($"Радиус окружности: {Radius}");
        }

        public double Area()
        {
            double r = Convert.ToDouble(Radius);
            return Math.PI * r * r;
        }

        public double Length()
        {
            double r = Convert.ToDouble(Radius);
            return 2 * Math.PI * r;
        }
    }
}
