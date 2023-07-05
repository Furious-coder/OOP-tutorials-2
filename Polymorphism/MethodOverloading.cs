using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class MethodOverloading
    {
        public void method()
        {
            Console.WriteLine("One");
        }
        public void method(int i)
        {
            Console.WriteLine("Two");
        }
        public void method(string s)
        {
            Console.WriteLine("Three");
        }
        public void method(string s, int i)
        {
            Console.WriteLine("four");
        }
    }
    public class Action:MethodOverloading
    {
        public static void Main(string[] args)
        {
            Action action = new Action();
            action.method();
            action.method(1);
            action.method("H");
            action.method("H", 8);
        }
    }
}
