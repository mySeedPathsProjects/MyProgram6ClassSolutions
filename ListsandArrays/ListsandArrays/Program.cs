using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsandArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //standard array
            string[] foodArray = new string[5];
            foodArray[0] = "quinoa";
            foodArray[1] = "grapes";

            //2-D Array
            int[,] twoD = new int[5, 5];
            twoD[1, 1] = 7;

            //convert array to a List
            List<string> foodList = foodArray.ToList();



            //LISTS
            List<string> teams = new List<string>();
            teams.Add("broncos");
            teams.Add("tigers");
            teams.Add("eagles");
            teams.Add("eagles");

            //sort the List of strings in alphabetical order
            teams.Sort();

            //print each team to screen
            //for (int i = 0; i < teams.Count; i++)
            //{
            //    Console.WriteLine(teams[i]);
            //}

            //Insert a new value, this one starting with a number
            teams.Insert(2, "6numTest");

            //print to screen
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }
            Console.WriteLine();

            //sort again to see if number is put before letter
            teams.Sort();

            //pring to screen (and YES it comes first)
            for (int i = 0; i < teams.Count; i++)
            {
                Console.WriteLine(teams[i]);
            }
            Console.WriteLine();


            //using CONTAINS (checks to see if a value is in the List...returns a boolean)
            Console.WriteLine(teams.Contains("broncos"));

            //using IndexOf
            Console.WriteLine(teams.IndexOf("eagles"));

            // delete item from List
            teams.Remove("eagles");
            teams.RemoveAt(0);




            //keep console open
            Console.ReadKey();
        }
    }
}
