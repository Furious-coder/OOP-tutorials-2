using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Specifiers
{
    public class Two:One
    {
       static void Main(string[] args)
        {
            Two t = new Two();
            t.two();  //two() is public so accessible from anywhere
            t.three(); //can access three() because TTwo class is a child class of One (protected)
            t.four();   //four() is internal and it is accessible beacuse it lies inside a same project ie.Access Specifiers
            t.five();  //five() is protected and internal and is accessible because internal/protected is accessible
            
        }

    }
    public class TTwo
    {
        static void Main(string[] args)
        {
            One one = new One();
            one.two();
            one.four();
            one.five();
            //cannot access three() because TTwo class is not a child class of One (protected)
        }
    }
}
