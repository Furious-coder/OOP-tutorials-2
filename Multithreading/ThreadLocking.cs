using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithreading
{
    internal class ThreadLocking
    {
        public void One()
        {
            lock (this)
            {
                Console.Write("Hello, ");
                Thread.Sleep(1000);
                Console.WriteLine("I am running");
            }
        }

        public static void Main(string[] args)
        {
            ThreadLocking TL= new ThreadLocking();
            Thread t1 = new Thread(TL.One);
            Thread t2 = new Thread(TL.One);
            Thread t3 = new Thread(TL.One);
            t1.Start();t2.Start();t3.Start();   

        }
    }
}
