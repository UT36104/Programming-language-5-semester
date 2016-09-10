using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle("RED", false, 2);
            Console.WriteLine(c1);
            Console.WriteLine(c1.GetArea());
            Console.WriteLine(c1.GetPerimeter());
            Console.WriteLine(c1.Color);
            Console.WriteLine(c1.IsFilled);
            Console.WriteLine(c1.Radius);
            Console.WriteLine();

            Rectangle r1 = new Rectangle("RED", false, 2, 1);
            Console.WriteLine(r1);
            Console.WriteLine(r1.GetArea());
            Console.WriteLine(r1.GetPerimeter());
            Console.WriteLine(r1.Color);
            Console.WriteLine(r1.IsFilled);
            Console.WriteLine(r1.Width);
            Console.WriteLine(r1.Height);
            Console.WriteLine();

            Square s1 = new Square(6.6);
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(s1.GetPerimeter());
            Console.WriteLine(s1.Color);
            Console.WriteLine(s1.IsFilled);
            Console.WriteLine(s1.Side);
            Console.WriteLine();

            MovablePoint m1 = new MovablePoint(5, 6, 10, 10);
            Console.WriteLine(m1);
            m1.MoveLeft();
            Console.WriteLine(m1);
            Console.WriteLine();

            MovableCircle m2 = new MovableCircle(2, new MovablePoint(5, 6, 10, 10));
            Console.WriteLine(m2);
            m2.MoveRight();
            Console.WriteLine(m2);

            Console.ReadLine();
        }
    }
}
