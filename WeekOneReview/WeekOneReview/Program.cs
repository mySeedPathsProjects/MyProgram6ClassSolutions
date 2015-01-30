using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekOneReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //calling the function for removing spaces
            //Console.WriteLine(SpaceRemover("a cat is a good pet"));

            //a built in space remover
            //string noSpaces = "  lots of spaces   ".Replace(" ", string.Empty);
            //Console.WriteLine(noSpaces);

            //***check for vowels*** using an in-line string
            //if ("aeiou".Contains(noSpaces[0].ToString().ToLower()))
            //{
            //    //blah blah blah
            //}

            //SpecificLetterCounter("s", "Sally is sunny");

            //Console.WriteLine(NumberRounder(2));
            //Console.WriteLine(NumberRounder(197));

            Console.WriteLine(AnnoyingTextFilter("how about this"));
            

            //keep console open
            Console.ReadKey();
        }
        /// <summary>
        /// Takes in a string, removes all spaces      
        /// </summary>
        /// <param name="inputString">string to de-space</param>
        /// <returns>string w/o any spaces</returns>
        static string SpaceRemover(string inputString)
        {
            //declare an empty return string
            //string.Empty same as = "";
            string returnString = string.Empty;

            //for loop over each letter
            for (int i = 0; i < inputString.Length; i++)
            {
                //get an individual letter
                string letter = inputString[i].ToString();
                if (letter != " ")
                {
                    //if letter is NOT a space
                    returnString = returnString + letter;
                }
            }
            //loop completes, return returnString
            return returnString;


        }
        /// <summary>
        /// counts number of instances of a spec letter in the string
        /// </summary>
        /// <param name="letterToCount">letter to count</param>
        /// <param name="stringToSearch">string to search</param>
        static void SpecificLetterCounter(string letterToCount, string stringToSearch)
        {
            //holds the number of matches found
            int letterCounter = 0;

            //loop through each letter
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                //check the letter, make each one lowercase
                if (letterToCount == stringToSearch[i].ToString().ToLower())
                {
                    //if the letter is found, increase by 1
                    letterCounter++;
                }
            }
            //Output:
            // <stringToSearch> has X of <letterToCount> in it
            // "Sally is sunny" has 3 s's in it
            Console.WriteLine("\"{0}\" has {1} {2}'s in it.", stringToSearch, letterCounter, letterToCount);
        }


        static int NumberRounder(int numberToRound)
        {
            if (numberToRound >= 0)
            {
                int remainder = numberToRound % 5;
                if (remainder < 3)
                {
                    return numberToRound - remainder;
                }
                else
                {
                    return numberToRound - remainder + 5;
                }
            }

            return 0;
        }

        /// <summary>
        /// making every other letter upper or lowercase
        /// </summary>
        /// <param name="notAnnoyingString">input string</param>
        /// <returns>effected output string</returns>
        static string AnnoyingTextFilter(string notAnnoyingString)
        {
            //will add each effected letter into this new string
            string annoyingString = string.Empty;

            //go through each letter, even index uppercase, odd index lowercase
            for (int i = 0; i < notAnnoyingString.Length; i++)
            {
                if (i % 2 == 0)
                {
                    //add letter to the string in uppercase
                   annoyingString += notAnnoyingString[i].ToString().ToUpper();
                }
                else
                {
                    //add letter to the string in lowercase
                   annoyingString += notAnnoyingString[i].ToString().ToLower();
                }
            }
            //return result
            return annoyingString;
        }

    }
}
