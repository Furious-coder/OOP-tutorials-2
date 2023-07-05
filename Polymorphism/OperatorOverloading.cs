using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class OperatorOverloading
    {
        int a,b,c,d;
        public  OperatorOverloading(int a,int b,int c,int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public override string ToString()
        {
            return a+"  "+b+"\n"+c+"  "+d;
        }
        public static OperatorOverloading operator +(OperatorOverloading obj1,OperatorOverloading obj2)
        {
            OperatorOverloading obj = new OperatorOverloading(obj1.a + obj2.a, obj1.b + obj2.b, obj1.c + obj2.c, obj1.d + obj2.d);
            return obj;
        }
    }

    public class Test
    {
        public static void Main(string[] args)
        {
            OperatorOverloading m1 = new OperatorOverloading(2, 3, 4, 5);
            OperatorOverloading m2 = new OperatorOverloading(8, 8, 8, 8);
            OperatorOverloading m3 = m1 + m2;
            Console.WriteLine(m3);
        }
    }
}
