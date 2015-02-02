using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of strings with student's names
            List<string> studentList = new List<string>() { "Eugene", "Patrick", "Linda", "Sergio", "Nate", "Michael G", "Andrii", "Nicole", "Juli", "Andrew", "Brandon E", "Maria", "Daniel", "Brandon S", "Mike S", "Laura", "Tim" };

            //call function
            PickGroup(studentList, 4);
   
            //keep Console open to see results
            Console.ReadKey();
        }

        /// <summary>
        /// Randomly pull names from a list and rearrange into groups of size groupSize
        /// </summary>
        /// <param name="studentList">List of student names</param>
        /// <param name="groupSize">size of new groups</param>
        static void PickGroup(List<string> studentList, int groupSize)
        {
            //will be used to temporarily hold current randomly chosen group of students
            List<string> currentGroupList = new List<string>();
            //will track how many new groups have been created
            int groupNumber = 1;
            //create a random number generator
            Random rng = new Random();

            //loop through studentList List and randomly chose one
            for (int i = studentList.Count-1; i >= 0; i--)
            {
                //randomly chose student name based on current length of List, add to temp group List, remove from original List
                string currentStudent = studentList[rng.Next(0, i+1)];
                currentGroupList.Add(currentStudent);
                studentList.Remove(currentStudent);

                //if size of temp List has reached groupSize or original student list is empty...
                if ((currentGroupList.Count == groupSize) || (studentList.Count == 0))
                {
                    //print each group to the screen
                    Console.WriteLine("GROUP {0}", groupNumber);
                    for (int j = 0; j < currentGroupList.Count; j++)
                    {
                        Console.WriteLine("{0}", currentGroupList[j]);
                    }
                    //extra WriteLine for readability 
                    Console.WriteLine();
                    //empty temp group List
                    currentGroupList.Clear();
                    groupNumber++;                  
                }
            }

        }
    }
}
