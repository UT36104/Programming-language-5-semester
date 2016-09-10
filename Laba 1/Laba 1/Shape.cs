namespace Laba_1
{
    public abstract class Shape
    {
        protected string color;
        protected bool filled;

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public string Color
        {
            get { return color; }
            set { Color = color; }
        }

        public bool IsFilled
        {
            get { return filled; }
            set { IsFilled = filled; }
        }

        public Shape()
        {
            color = "BLACK";
            filled = false;
        }

        public Shape(string Color, bool Filled)
        {
            color = Color;
            filled = Filled;
        }

        public override string ToString()
        {
            return $"Цвет: {color}, Закрашена: {filled}.";
        }
    }
}