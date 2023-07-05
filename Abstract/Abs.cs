using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public abstract class Abs
    {
        public int length, breadth,radius;
        public const float PI= 3.14f;

        public abstract double Area();
       
    }
    public class Rectangle : Abs
    {
        public Rectangle(int len, int br)
        {
            this.length = len;
            this.breadth = br;
        }
        public override double Area()
        {
            return length * breadth;
        }
    }

    public class Square : Abs
    {
        public Square(int len)
        {
            this.length = len;
            
        }
        public override double Area()
        {
            return length * length;
        }
    }

    public class Circle : Abs
    {
        public Circle(int rad)
        {
            this.radius = rad;
        }
        public override double Area()
        {
            return PI*radius*radius;
        }
    }

    public class Action
    {
        public static void Main(string[] args)
        {
            Abs r = new Rectangle(5, 7);
            Abs s = new Square(6);
            Abs c = new Circle(12);
           Console.WriteLine( r.Area());
           Console.WriteLine( s.Area());
           Console.WriteLine( c.Area());
        }
    }
}
