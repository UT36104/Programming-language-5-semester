using System;

namespace Laba_1
{
    public class Circle : Shape
    {
        protected double radius;

        public double Radius {
            get { return radius; }
            set { Radius = radius; }
        }

        public Circle()
        {
            color = "BLACK";
            filled = false;
            radius = 1.0;
        }

        public Circle(double Radius)
        {
            radius = Radius;
        }

        public Circle(string Color, bool Filled, double Radius)
        {
            color = Color;
            filled = Filled;
            radius = Radius;
        }

        public override double GetArea()
        {
            double s = Math.PI * Math.Pow(radius, 2);
            return s;
        }

        public override double GetPerimeter()
        {
            double p = 2 * Math.PI * radius;
            return p;
        }

        public override string ToString()
        {
            return $"Цвет: {color}, Закрашена: {filled}, Радиус: {radius}, Площадь: {GetArea()}, Периметр {GetPerimeter()}";
        }
    }
}