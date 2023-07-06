using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public class Test
    {
        public enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday
        }

        public class Action
        {
            public static Days OfficeDays { get; set; } /*= Days.Monday;*/

            static void Main(string[] args)
            {
                Console.WriteLine(OfficeDays);
                OfficeDays = Days.Friday;
                Console.WriteLine(OfficeDays);

                Console.ReadLine();
            }
        }
      
    }
}
