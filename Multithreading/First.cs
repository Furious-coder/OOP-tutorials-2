using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class First
    {
        public static void Test1(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Test1 is executing");
            }
        }
        public static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2 is executing");
                if (i == 50)
                {
                    Console.WriteLine("Thread 2 is sleeping");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread 2 woke up");
                }
            }
        }
        public static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 is executing");
            }
        }
        static void Main(string[] args)
        {
            ParameterizedThreadStart obj = new ParameterizedThreadStart(Test1);
            Thread t1 = new Thread(obj);
            Thread t2= new Thread(Test2);
            Thread t3= new Thread(Test3);
            t1.Start(10);
            t2.Start();
            t3.Start();
        }
    }
}
