using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingCoins
{
    class Program
    {
        //**GLOBAL VARIABLES**

        static Random randomNumberGenerator = new Random();

        //**MAIN PROGRAM FUNCTION**
        static void Main(string[] args)
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(FlipACoin());
            //}

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(FlipForHeads());

            }

            //keep the window open
            Console.ReadKey();

        }

        //**NEW FUNCTIONS GO BELOW HERE**

        /// <summary>
        /// Flips a "coin" and returns a string of either "Heads" or "Tails"
        /// </summary>
        /// <returns>string of either "Heads" or "Tails"</returns>
        static string FlipACoin()
        {
            int theFlip = randomNumberGenerator.Next(0, 2);
            if (theFlip == 0)
            {
                return "Heads";
            }
            return "Tails";
        }

        /// <summary>
        /// Flips a coin until a heads has been flipped
        /// </summary>
        /// <returns>number of tries until a head has flipped</returns>
        static int FlipForHeads()
        {
            //a "flag" to tell us when to escape the loop
            bool headsHasNotBeenFlipped = true;
            //counter for number of flips until we get a "head"
            int howManyFlips = 0;

            //loop for flipping coin
            while (headsHasNotBeenFlipped)
            {
                //variable to hold result of coin flip
                string theFlip = FlipACoin();
                //counter gets updated
                howManyFlips++;
                //check if it's "heads"
                if (theFlip == "Heads")
                {
                    //if it's "heads" then finish flipping
                    headsHasNotBeenFlipped = false;
                }
            }
            //return the number of flips
            return howManyFlips;
        }
    }
}
