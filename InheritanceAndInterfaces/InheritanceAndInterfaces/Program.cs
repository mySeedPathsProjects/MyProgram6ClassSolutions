using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee John = new Employee("John", "Doe", "Stalker");
            John.Talk();
            Console.WriteLine();
            Janitor Jeff = new Janitor("Jeff", "Macco");
            Jeff.Talk();
            Jeff.Sweep();
            Console.WriteLine();
            Musician Hank = new Musician("Hank", "Jones", "Drums");
            Hank.Talk();
            Hank.Jam();
            Console.WriteLine();

            Bird bird = new Bird();

            List<ISing> listOfThingsThatSing = new List<ISing>();
            listOfThingsThatSing.Add(Hank);
            listOfThingsThatSing.Add(bird);

            foreach (ISing singers in listOfThingsThatSing)
            {
                singers.Sing();
            }

            Console.ReadKey();
        }
    }


    #region "INHERITANCES"
    //abstract class: cannot be instantiated
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Constructor
        public Person(string fname, string lname)
        {
            this.FirstName = fname; this.LastName = lname;
        }

        //Methods
        public void Walk()
        {
            Console.WriteLine("Whistle");
        }

        //need "virtual" so you can override it in the child class
        public virtual void Talk()
        {
            Console.WriteLine("Hello, my name is {0} {1}", this.FirstName, this.LastName);
        }
    }

    //employee inherits the Person class
    public class Employee : Person 
    {
        public string JobTitle { get; set; }

        //Constructor
        public Employee(string fname, string lname, string jobTitle) : base(fname, lname)
        {
            //base constructor already took care of fname and lname
            this.JobTitle = jobTitle; 
        }

        //Methods
        //"overrides" the base class
        public override void Talk()
        {
            //if we want to include the base class behavior
            base.Talk();
            Console.WriteLine("I'm a {0}", this.JobTitle);
        }

    }

    public class Janitor : Employee
    {
        public int NumberOfBrooms { get; set; }

        public Janitor(string fname, string lname)
            : base(fname, lname, "Janitor")
        {
            //nothing needs to go into Constructor b/c base classes handled it
            this.NumberOfBrooms = 3;
        }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("I'm a person, too");
        }

        public void Sweep()
        {
            Console.WriteLine("sweep sweep sweep");
        }
    }

    public class Musician : Employee, ISing
    {
        public string Instrument { get; set; }

        public Musician(string fname, string lname, string instrument)
            : base(fname, lname, "Musician")
        {
            this.Instrument = instrument;
        }

        public override void Talk()
        {
            base.Talk();
            Console.WriteLine("I love playing my " + this.Instrument.ToLower());
        }

        public void Jam()
        {
            Console.WriteLine("This guy is rocking out!!!!");
        }

        public void Sing()
        {
            Console.WriteLine("Oh sweet child o mine");
        }
    }
    #endregion


#region "INTERFACES"

    interface ISing
    {
        //framework for describing something that sings
        //provides no information on how it sings (does not implement how it sings)

        void Sing();
    }

    class Bird : ISing
    {
        public void Sing()
        {
            Console.WriteLine("chirp chirp chirp");
        }
    }


    interface ICombustionEngine
    {
        int FuelLevel { get; set; }

        void Refuel(int fuel);
        void Go();
    }

    public class Jet : ICombustionEngine
    {

        public int FuelLevel
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Refuel(int fuel)
        {
            this.FuelLevel += fuel;
        }

        public Jet()
        {
            this.FuelLevel = 20;
        }

        public void Go()
        {
            if (this.FuelLevel > 25)
            {
                Console.WriteLine("Vrooom!!!");
                this.FuelLevel -= 25;
            }
            else
            {
                Console.WriteLine("out of gas");
            }
        }
    }

    public class Generator : ICombustionEngine
    {
        public int FuelLevel { get; set; }

        public Generator()
        {
            this.FuelLevel = 20;
        }

        public void Refuel(int fuel)
        {
            this.FuelLevel = fuel;
        }

        public void Go()
        {
            if (this.FuelLevel >= 10)
            {
                Console.WriteLine("I'm making power");
            }
            else
            {
                Console.WriteLine("out of gas");
            }
        }
    }
#endregion
}
