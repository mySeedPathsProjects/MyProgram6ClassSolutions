using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowCourseConstructors();

            Console.ReadKey();
        }

        static void ShowCourseConstructors()
        {
            Course course1 = new Course();
            Course course2 = new Course("Biology");
            Course course3 = new Course("Math 101", "A");

            course1.PrintCourseInfo();
            course2.PrintCourseInfo();
            course3.PrintCourseInfo();

            course2.LetterGrade = "b";  //in setter we have "value.ToUpper()";
            course2.PrintCourseInfo();
        }



        //NEW FUNCTIONS GO HERE


    }
    //NEW CLASSES GO HERE

    public class Course
    {
        //STEP 1:  DEFINE PROPERTIES
        
        //CREATING PROPERTIES
        // Step 1: Create the hide-behind variable (make it "private")
        private string _name;
        // Step 2: Create the property layer that sits on top of that variable.  It controls the interaction with the variable.
        // most Properties should be "public"
        // can make it read-only or write-only if you want
        public string Name
        {
            get
            {
                //Getter:  whenever the value is on the right side of an equation, this code is run.
                //eg. myString = myObject.Name:
                return _name.ToUpper();  //can write something like "return _name.ToUpper();" so it always gets returned in Uppercase
            }
            set
            {
                //Setter:  whenever the value is on the left side of an equation, this code is run.
                //eg. myObject.Name = "Nickelback";
                _name = value;  // ex.  _name = value.Replace(" ", "").ToLower();  can make it more specific and controlled
            }
        }

        private string _letterGrade;
        public string LetterGrade
        {
            get { return _letterGrade; }
            set { _letterGrade = value.ToUpper(); }  //  _letterGrade = value.ToUpper() since the switch statement reading LetterGrade in "GradePoints" is looking for an uppercase letter just below
        }

        //for the Grade Points, we are going to do a READ-ONLY property
        public double GradePoints
        {
            get
            {
                switch (this.LetterGrade)
                {
                    case "A":   //looking for a capital letter "A", as mentioned above
                        return 4.0;
                    case "B":
                        return 3.0;
                    case "C":
                        return 2.0;
                    case "D":
                        return 1.0;
                    default:
                        return 0.0;
                }
            }
        }

        // STEP 2:  DEFINE CONSTRUCTOR(S)...one is built in automatically if you don't make one

        //Parameter-less constructor, think of it as a "default constructor", gives default info
        public Course()
        {
            this.Name = "Undefined";
            this.LetterGrade = "I";
        }
        //MORE COMMON this is a constructor you'll usually use...HAS PARAMETERS
        public Course(string name)
        {
            this.Name = name;
            this.LetterGrade = "I";
        }

        public Course(string name, string letterGrade)
        {
            this.Name = name;
            this.LetterGrade = letterGrade;
        }
        
        // STEP 3:  DEFINE ITS METHODS (actions) what can it do
        public void PrintCourseInfo()
        {
            Console.WriteLine("{0, 15} {1, 2} {2, 3}", this.Name, this.LetterGrade, this.GradePoints);
        }
    }
}
