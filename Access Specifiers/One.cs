using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers
{
    public class One
    {
        private void one()
        {
            Console.WriteLine("Private method called");
        }
        public void two()
        {
            Console.WriteLine("Public method called");
        }
        protected void three()
        {
            Console.WriteLine("Protected method called");
        }
        internal void four()
        {
            Console.WriteLine("Internal method called");
        }
        protected internal void five()
        {
            Console.WriteLine("Protected internal method called");
        }
        static void Main(string[] args)
        {
            One a = new One();
            a.one();
            a.two();
            a.three();  
            a.four();
            a.five();
        }
    }
}
