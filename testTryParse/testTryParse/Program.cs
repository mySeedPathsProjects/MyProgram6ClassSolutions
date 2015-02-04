using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testTryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            testTryParse("s");
            Console.ReadLine();
        }

        static void testTryParse(string inputString)
        {
            int userInt = 0;
            if (int.TryParse(inputString, out userInt))
            {
                Console.WriteLine("works");
            }
            Console.WriteLine("nope");
        }
    }
}
