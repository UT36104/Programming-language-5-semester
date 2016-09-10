namespace Laba_1
{
    public class MovablePoint
    {
        protected int x;
        protected int y;
        protected int xSpeed;
        protected int ySpeed;

        public override string ToString()
        {
            return $"Координата точки на оси Х'Х и Y'Y соответственно: {x}:{y}, Cкорость движения точки по оси Х'Х и Y'Y соответственно: {xSpeed}:{ySpeed}.";
        }
    }
}