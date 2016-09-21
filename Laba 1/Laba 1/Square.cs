using System;

namespace Laba_1
{
    public class Square : Rectangle
    {
        public double Side
        {
            get { return width; }
            set { width = height = value; }
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
            color = "BLACK";
            filled = false;
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
            double s = Math.Pow(width, 2);
            return s;
        }

        public override double GetPerimeter()
        {
            double p = 4 * width;
            return p;
        }

        public override string ToString()
        {
            return $"Цвет: {color}, Закрашена: {filled}, Сторона: {height}, Площадь: {GetArea()}, Периметр {GetPerimeter()}";
        }
    }
}