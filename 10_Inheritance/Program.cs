using System.Xml.Linq;

namespace _10_Inheritance
{
    abstract class Person: Object
    {
        //private public protected
        private string name;
        private readonly DateTime birthdate;

        public Person()
        {
            name = "no name";
            birthdate = new DateTime();
        }
        public Person(string n, DateTime b)
        {
            name = n;
            if( b > DateTime.Now)
            {
                birthdate = new DateTime();
            }
            else
            {
                birthdate = b;
            }            
        }

        public override string ToString()
        {
            return $"Name : {name}. Birthdate : {birthdate.ToShortDateString()}";
        }
        //virtual override
        public virtual void Print()
        {
            Console.WriteLine($"Name : {name}. Birthdate : {birthdate.ToShortDateString()}");
        }
        public abstract void DoWork();
     
    }
    //class Name : (public) BaseClass, Interface1, Interface2
    class Worker : Person
    {
        private decimal salary;

        public decimal Salary
        {
            get { return salary; }
            set 
            {
                salary = value >= 0 ? value : 0;
            }
        }
        public Worker() : base()
        {
            Salary = 0;
        }
        public Worker(string n, DateTime b, decimal s): base(n,b)
        {
            Salary = s;
        }
        public override string ToString()
        {
            return base.ToString() + $"Salary : {Salary}";
        }
        // public new void Print() - new create new method , stop override
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Salary : {Salary}");
        }
        public override void DoWork()
        {
            Console.WriteLine("Doing some work.....");
        }
    }
    //sealed class - заборонений до наслідування
    //sealed method - заборонений до перевизначення
    class Programmer :Worker
    {
        public int CountLines { get; set; }
        public Programmer():base()
        {
            CountLines = 0; 
        }
        public Programmer(string n, DateTime b, decimal s):base(n,b,s)
        {
            CountLines = 0;
        }
        public sealed override  void DoWork()
        {
            Console.WriteLine("Write C# code");
        }
        public void WriteOneLine()
        {
            CountLines++;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Count lines : {CountLines}");
        }
    }
    class TeamLead: Programmer
    {
        public int CountProjects { get; set; }
        //public override void DoWork()
        //{
        //    Console.WriteLine("Manage team project");
        //}
    }
    class CollectionPeople
    {
        Person[] persons;
        public CollectionPeople(params Person[] persons)
        {
            this.persons = persons;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CollectionPeople collection = new CollectionPeople(new Worker(),
                new Programmer(), new TeamLead());
            Worker worker = new Worker("Vova",new DateTime(2000,2,12),20000.0m);
            //Console.WriteLine(worker);
            worker.Print();
            worker.DoWork();    

            Person[] people = new Person[]
            {
                worker,
                //new Person(),
                new Programmer("Oleg", new DateTime(1995,5,7),45000),
                new TeamLead()
            };
            Console.WriteLine("-----------------------------------");
            foreach (var person in people)
            {
                person.Print();
                Console.WriteLine();
                person.DoWork();
            }
        }
    }
}
