namespace Laba_1
{
    public class MovableRectangle : IMovable
    {
        private MovablePoint topLeft;
        private MovablePoint bottomRight;

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
            return $"Верхняя левая точка {topLeft}, нижняя правая точка  {bottomRight}.";
        }
    }
}