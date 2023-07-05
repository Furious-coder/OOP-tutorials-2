using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class MethodOverriding
    {
        public virtual void method()
        {
            Console.WriteLine("Parent");
        }

    }
    class Child : MethodOverriding
    {
        public override void method()
        {
            Console.WriteLine("Child");
        }
        public static void Main(string[] args)
        {
            Child c = new Child();
            MethodOverriding m = new MethodOverriding();
            c.method();
            m.method();
            
        }
    }
}
