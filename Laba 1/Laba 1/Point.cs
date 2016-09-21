namespace Laba_1
{
    public class Point
    {
        protected int x;
        protected int y;

        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public override string ToString()
        {
            return $"X: {x}, Y: {y}";
        }
    }
}
