namespace Laba_1
{
    public class MovableCircle : Circle, IMovable
    {
        private MovablePoint center;

        public MovableCircle(int Radius, MovablePoint Center)
        {
            radius = Radius;
            center = Center;
        }
        
        public void MoveUp()
        {
            center.MoveUp();
        }

        public void MoveDown()
        {
            center.MoveDown();
        }

        public void MoveLeft()
        {
            center.MoveLeft();
        }

        public void MoveRight()
        {
            center.MoveRight();
        }

        public override string ToString()
        {
            return $"Радиус {radius}, Центр {center}";
        }
    }
}