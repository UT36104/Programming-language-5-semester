namespace Laba_1
{
    public class MovableRectangle : IMovable
    {
        private MovablePoint topLeft;
        private MovablePoint bottomRight;

        public MovableRectangle(MovablePoint TopLeft, MovablePoint BottomRight)
        {
            topLeft = TopLeft;
            bottomRight = BottomRight;
        }

        public void MoveUp()
        {
            topLeft.MoveUp();
            bottomRight.MoveUp();
        }

        public void MoveDown()
        {
            topLeft.MoveDown();
            bottomRight.MoveDown();
        }

        public void MoveLeft()
        {
            topLeft.MoveLeft();
            bottomRight.MoveLeft();
        }

        public void MoveRight()
        {
            topLeft.MoveRight();
            bottomRight.MoveRight();
        }

        public override string ToString()
        {
            return $"Верхняя левая точка {topLeft}, нижняя правая точка  {bottomRight}";
        }
    }
}