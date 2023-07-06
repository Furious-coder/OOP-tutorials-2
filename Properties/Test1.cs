using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Test1
    {
        int age = 30;

        public int Getage()
        {
            return age;
        }

        public void Setage(int age)
        {
            this.age = age;
        }

    }


    public class Action
    {
        public static void Main(string[] args)
        {
            Test1 test1 = new Test1();
            Console.WriteLine(test1.Getage());
            test1.Setage(60);
            Console.WriteLine(test1.Getage());
        }
    }
}
