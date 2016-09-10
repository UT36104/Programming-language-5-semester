namespace Laba_1
{
    public class MovablePoint : IMovable
    {
        protected int x;
        protected int y;
        protected int xSpeed;
        protected int ySpeed;

        public MovablePoint(int X, int Y, int XSpeed, int YSpeed)
        {
            x = X;
            y = Y;
            xSpeed = XSpeed;
            ySpeed = YSpeed;
        }

        public void MoveUp()
        {
            
        }

        public void MoveDown()
        {

        }

        public void MoveLeft()
        {

        }

        public void MoveRight()
        {

        }

        public override string ToString()
        {
            return $"Координата точки на оси Х'Х и Y'Y соответственно: {x}:{y}, Cкорость движения точки по оси Х'Х и Y'Y соответственно: {xSpeed}:{ySpeed}.";
        }
    }
}