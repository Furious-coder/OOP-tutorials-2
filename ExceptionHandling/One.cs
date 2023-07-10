using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class One
    {
        int x, y;
        public static void Main(string[] args)
        {
            One a = new One();
            Console.WriteLine("Enter first numbers: ");
            a.x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second numbers: ");
            a.y = Convert.ToInt32(Console.ReadLine());

            try
            {
                int result = a.x / a.y;
                Console.WriteLine(result);
            }
            catch (Exception ex )
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Further executions");
            }
        }
    }
}
