using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughStrings
{
    class Program
    {
        static void Main(string[] args)
        {

            string testString = "the lazy dog jumps over the also lazy bear";
            //Console.WriteLine("We found {0} vowels in \"{1}\".", VowelCounter3000(testString), testString);

            //Console.WriteLine("The average length of a word in \"{0}\" is {1}", testString, AverageWordLengthFinder8000(testString));

            OldTimeyTextPrinter(testString, 50);
            OldTimeyTextPrinter(testString, 100);


            //***THESE ARE LAMBDA EXPRESSIONS USED IN C# ONLY!!!***

            //another way to do AverageLengthFinder
            //Console.WriteLine(testString.Split(' ').Average(x => x.Length));

            //antoher way to do VowelCounter
            //Console.WriteLine(testString.Count(x => "aeiou".Contains(x.ToString().ToLower())));

            Console.ReadKey();

        }

        //new functions are declared outside of other functions, but inside of a class

       /// <summary>
       /// prints chars from a string to the screen with a pause duration between each char
       /// </summary>
       /// <param name="inputText">the string</param>
       /// <param name="pauseDuration">amount of pause time in ms</param>
        static void OldTimeyTextPrinter(string inputText, int pauseDuration)
        {
            //loop through each character
            for (int i = 0; i < inputText.Length; i++)
            {
                //get a letter
                char letter = inputText[i];
                Console.Write(letter);
                System.Threading.Thread.Sleep(pauseDuration);
            }
             //after text is complete do a line return
            Console.WriteLine();

        }

        /// <summary>
        /// find the average length of each word in a string
        /// </summary>
        /// <param name="inputText">string</param>
        /// <returns>average length of characters in each word in the string</returns>
        static double AverageWordLengthFinder8000(string inputText)
        {
            //counters to hold our values to calculate an average
            double totalNumberOfCharacters = 0;
            double totalNumberOfWords = 0;

            //we need to split a string to words
            string[] wordArray = inputText.Split(' ');

            //loop through each word in wordArray
            for (int i = 0; i < wordArray.Length; i++)
            {
                //get the current word
                string currentWord = wordArray[i];
                //let's process the word
                totalNumberOfWords++;
                totalNumberOfCharacters += currentWord.Length;
            }

            //return our results w/ an average
            return totalNumberOfCharacters / totalNumberOfWords;
        }

        /// <summary>
        /// count the number of vowels in a string
        /// </summary>
        /// <param name="inputText">string</param>
        /// <returns>number of vowels found</returns>
        static int VowelCounter3000(string inputText)
        {
            //this is our counter for vowels
            int numberOfVowelsFound = 0;

            //need to loop through all indexes to compare each letter
            for (int i = 0; i < inputText.Length; i++)
            {
                //pull out individual letter at current index and convert ToLower
                char letter = char.ToLower(inputText[i]);
                //is it a vowel?
                if (letter == 'a' ||
                    letter == 'e' ||
                    letter == 'i' ||
                    letter == 'o' ||
                    letter == 'u')
                {
                    //yes it is a vowel
                    //increase "counter" 
                    numberOfVowelsFound++;
                }
            }
            //loop complete, gone through entire string, rtn num of vowels found
            return numberOfVowelsFound;
        }
    }
}
