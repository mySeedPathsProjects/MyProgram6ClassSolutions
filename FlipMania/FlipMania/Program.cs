using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        //**I guess we aren't declaring Random globally??
        //static Random randomNumberGenerator = new Random();

        static void Main(string[] args)
        {
            FlipCoins(10000);
            //the following Console.WriteLine() added for a line break to improve readability in console
            Console.WriteLine();
            FlipForHeads(10000);
            Console.ReadKey();
        }


        /// <summary>
        /// virtual random coin flip, counts num of head and tails
        /// </summary>
        /// <param name="numberOfFlips">times to flip the coin</param>
        static void FlipCoins(int numberOfFlips)
        {
            //check for valid input (positive number)
            if (numberOfFlips > 0)
            {
                int numberOfHeads = 0;
                int numberOfTails = 0;
                //is there where and how you wanted another instance of Random declared?
                //I'm not sure why we aren't using a global declaration
                Random rng = new Random();

                //the coin flip, counting num of heads and tails
                for (int i = 0; i < numberOfFlips; i++)
                {
                    if (rng.Next(0, 2) == 0)
                    {
                        numberOfHeads++;
                    }
                    else
                    {
                        numberOfTails++;
                    }
                }

                Console.WriteLine("We flipped a coin {0} times.", numberOfFlips);
                Console.WriteLine("Number of Heads: {0}", numberOfHeads);
                Console.WriteLine("Number of Tails: {0}", numberOfTails);
            }
        }

        /// <summary>
        /// Enter num of heads you want, keeps flipping until that number reached
        /// </summary>
        /// <param name="numberOfHeads">int</param>
        static void FlipForHeads(int numberOfHeads)
        {
            if (numberOfHeads > 0)
            {
                int numberOfHeadsFlipped = 0;
                int totalFlips = 0;
                //is this where and how you wanted another instance of Random declared?
                //I'm not sure why we aren't using a global declaration
                Random rng = new Random();

                //keep flipping the coin until we reach numberOfHeads
                //and keep track of total num of flips to reach numberOfHeads
                while (numberOfHeadsFlipped <= numberOfHeads)
                {
                    if (rng.Next(0, 2) == 0)
                    {
                        numberOfHeadsFlipped++;
                    }
                    totalFlips++;
                }
                Console.WriteLine("We are flipping a coin until we find {0} heads.", numberOfHeads);
                Console.WriteLine("It took {0} flips to find {1} heads.", totalFlips, numberOfHeads);
            }
        }
    }
}
