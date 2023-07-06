using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate void Onnee(int x);
    public delegate string Twwoo(int x);
    internal class Delegate1
    {
        public void One(int x)
        {
            Console.WriteLine("One executed "+ x);
        }

        public static string Two(int x)
        {
            return "Two Executed " + x;
        }

        public static void Main(string[] args)
        {
           
            Delegate1 d = new Delegate1();
            Onnee o = new Onnee(d.One);
            Twwoo t = new Twwoo(Two); // (Delegate1.Two) should be used if defining on different class.
            o(3);
            string ot = t(5);
            Console.WriteLine(ot);
        }
    }
}
