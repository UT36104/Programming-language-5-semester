namespace Laba_1
{
    public class MovableCircle : IMovable
    {
        private int radius;
        private MovablePoint center;

        public MovableCircle(int Radius, MovablePoint Center)
        {
            radius = Radius;
            center = Center;
        }
        
        public void MoveUp()
        {
            //center = new MovablePoint(XSpeed:, 1, 2, 1);
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
            return $"Радиус {radius}, Центр {center}.";
        }
    }
}