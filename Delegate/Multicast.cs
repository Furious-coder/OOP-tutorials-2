using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Rectangle(int x, int y);
    internal class Multicast
    {
        public void Area(int l, int b)
        {
            Console.WriteLine("Area of rectangle: " + l * b);
        }

        public void Peri(int l, int b)
        {
            Console.WriteLine("Perimeter of rectangle: " + (2*(l + b)));
        }

        public static void Main(string[] args)
        {
            Multicast s = new Multicast();
            Rectangle r = s.Area;
            r += s.Peri;
            r.Invoke(3, 8);
        }
    }
}
