using System;

namespace Laba_1
{
    public class Square : Rectangle
    {
        public double Side
        {
            get { return width; }
            set { Width = width; Height = height; }
        }

        public Square()
        {
            color = "BLACK";
            filled = false;
            width = 1.0;
            height = 1.0;
        }

        public Square(double WidthHeight)
        {
            width = WidthHeight;
            height = WidthHeight;
        }

        public Square(string Color, bool Filled, double WidthHeight)
        {
            color = Color;
            filled = Filled;
            width = WidthHeight;
            height = WidthHeight;
        }

        public override double GetArea()
        {
            double s = 6 * Math.Pow(width, 6);
            return s;
        }

        public override double GetPerimeter()
        {
            double p = 12 * width;
            return p;
        }

        public override string ToString()
        {
            return $"Цвет: {color}, Закрашена: {filled}, Сторона: {height}, Площадь: {GetArea()}, Периметр {GetPerimeter()}";
        }
    }
}