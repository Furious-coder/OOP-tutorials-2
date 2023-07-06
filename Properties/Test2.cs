using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Test2
    {
        int _Age=20;


        public int Age { get { return _Age; } set {
                if(value > 18)
                _Age = value; } }
       
        public class Action
        {
            public static void Main(string[] args)
            {
                Test2 test = new Test2();
               Console.WriteLine( test.Age);
                test.Age = 25;
                Console.WriteLine(test.Age);
            }
        }
    }
}
