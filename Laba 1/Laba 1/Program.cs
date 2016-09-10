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


            /*Shape s1 = new Shape("RED", false);
            Console.WriteLine(s1);
            Console.WriteLine(s1.GetArea());
            Console.WriteLine(s1.GetPerimeter());
            Console.WriteLine(s1.Color);
            Console.WriteLine(s1.IsFilled);
            Console.WriteLine(s1.Radius);

            Circle c1 = (Circle)s1;
            System.Console.WriteLine(c1);
            System.Console.WriteLine(c1.GetArea());
            System.Console.WriteLine(c1.GetPerimeter());
            System.Console.WriteLine(c1.Color);
            System.Console.WriteLine(c1.IsFilled);
            System.Console.WriteLine(c1.Radius);

            Shape s2 = new Shape();

            Shape s3 = new Rectangle(1.0, 2.0, "RED", false);
            System.Console.WriteLine(s3);
            System.Console.WriteLine(s3.GetArea());
            System.Console.WriteLine(s3.GetPerimeter());
            System.Console.WriteLine(s3.Color);
            System.Console.WriteLine(s3.Width);

            Rectangle r1 = (Rectangle)s3;
            System.Console.WriteLine(r1);
            System.Console.WriteLine(r1.GetArea());
            System.Console.WriteLine(r1.Color);
            System.Console.WriteLine(r1.Width);

            Shape s4 = new Square(6.6);
            System.Console.WriteLine(s4);
            System.Console.WriteLine(s4.GetArea());
            System.Console.WriteLine(s4.Color);
            System.Console.WriteLine(s4.Side);

            Rectangle r2 = (Rectangle)s4;
            System.Console.WriteLine(r2);
            System.Console.WriteLine(r2.GetArea());
            System.Console.WriteLine(r2.Color);
            System.Console.WriteLine(r2.Side);
            System.Console.WriteLine(r2.Height);

            Square sq1 = (Square)r2;
            System.Console.WriteLine(sq1);
            System.Console.WriteLine(sq1.GetArea());
            System.Console.WriteLine(sq1.Color);
            System.Console.WriteLine(sq1.Side);
            System.Console.WriteLine(sq1.Height);


            Movable m1 = new MovablePoint(5, 6, 10);
            System.Console.WriteLine(m1);
            m1.MoveLeft();
            System.Console.WriteLine(m1);

            Movable m2 = new MovableCircle(2, 1, 2, 20);
            System.Console.WriteLine(m2);
            m2.MoveRight();
            System.Console.WriteLine(m2);
            */

            Console.ReadLine();
        }
    }
}
