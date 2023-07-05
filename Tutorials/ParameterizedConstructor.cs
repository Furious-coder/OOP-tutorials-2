using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Tutorials
{
    class ParameterizedConstructor
    {
       public int a,b;
        public ParameterizedConstructor(int a)
        {
            this.a = a;
            Console.WriteLine("Value of a is: "+this.a);
        }
        public ParameterizedConstructor(int a, int b) //Constructor overloading
        {
            this.a=a;
            this.b=b;
            Console.WriteLine($"Value of a is {this.a} and b is {this.b}");
        }
        public static void Main(string[] args)
        {
            ParameterizedConstructor c1 = new ParameterizedConstructor(50);
            ParameterizedConstructor c2 = new ParameterizedConstructor(80,100);
        }
    }
}
