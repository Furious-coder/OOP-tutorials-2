using System;


namespace Tutorials
{
    class ImplicitConstructor
    {
        public int x;
        public bool y;

        static void Main(string[] args)
        {
            ImplicitConstructor c = new ImplicitConstructor();
            Console.WriteLine("Value of x is: " + c.x);
            Console.WriteLine("Value of y is: " + c.y);
        }
    }
    //class Try
    //{
      
    //    public static void main(string[] args)
    //    {
    //        ImplicitConstructor c = new ImplicitConstructor();
    //        Console.WriteLine("Value of x is: " + c.x);
    //        Console.WriteLine("Value of y is: " + c.y);
    //    }
    //}
}
