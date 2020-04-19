using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables
            int a = 0, b = 0, c = 0, d = 0, e = 0, sum = 0;

            do
            {
                //Requesting data from the user
                Console.Write(" Enter the first number: ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a < 0 || a > 147483647);

            do
            {
                Console.Write(" Enter the second number: ");
                b = Convert.ToInt32(Console.ReadLine());
            }
            while (b < 0 && b > 147483647);

            do
            {
                Console.Write(" Enter the third number: ");
                c = Convert.ToInt32(Console.ReadLine());
            }
            while (c < 0 && c > 147483647);

            do
            {
                Console.Write(" Enter the fourth number: ");
                d = Convert.ToInt32(Console.ReadLine());
            }
            while (d < 0 && d > 147483647);

            do
            {
                Console.Write(" Enter the fifth number: ");
                e = Convert.ToInt32(Console.ReadLine());
            }
            while (e < 0 && e > 147483647);

            //calculating sum
            sum = a + b + c + d + e;

            //Showing result
            Console.Write(" {0} + {1} + {2} + {3} + {4} = {5}",a ,b , c, d, e, sum);

            Console.ReadKey();
        }
    }
}
