namespace Laba_1
{
    public class Rectangle : Shape
    {
        protected double width;
        protected double height;

        public double Width
        {
            get { return width; }
            set { Width = width; }
        }

        public double Height
        {
            get { return height; }
            set { Height = height; }
        }

        public Rectangle()
        {
            color = "BLACK";
            filled = false;
            width = 2.0;
            height = 1.0;
        }

        public Rectangle(double Width, double Height)
        {
            width = Width;
            height = Height;
        }

        public Rectangle(string Color, bool Filled, double Width, double Height)
        {
            color = Color;
            filled = Filled;
            width = Width;
            height = Height;
        }

        public override double GetArea()
        {
            double s = width * height;
            return s;
        }

        public override double GetPerimeter()
        {
            double p = 2 * (width + height);
            return p;
        }

        public override string ToString()
        {
            return $"Цвет: {color}, Закрашена: {filled}, Высота: {height}, Ширина: {width}, Площадь: {GetArea()}, Периметр {GetPerimeter()}";
        }
    }
}